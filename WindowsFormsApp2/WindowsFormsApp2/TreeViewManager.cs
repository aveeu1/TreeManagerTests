using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATP
{
    class TreeViewManager
    {
        private TreeView m_treeView;
        private Dictionary<string, TreeNode> nodeMap = new Dictionary<string, TreeNode>();
        private Dictionary<string, NodeInfo> parentMap = new Dictionary<string, NodeInfo>(); // Store parent and index

        public TreeViewManager(TreeView treeView)
        {
            this.m_treeView = treeView;
            LoadTree(); // Load existing nodes
        }

        private struct NodeInfo
        {
            public TreeNodeCollection Parent;
            public int Index;
            public NodeInfo(TreeNodeCollection parent, int index)
            {
                Parent = parent;
                Index = index;
            }
        }

        private void LoadTree()
        {
            nodeMap.Clear();
            parentMap.Clear();

            foreach (TreeNode node in m_treeView.Nodes)
            {
                LoadNodeRecursive(node, m_treeView.Nodes, m_treeView.Nodes.IndexOf(node));
            }
        }

        private void LoadNodeRecursive(TreeNode node, TreeNodeCollection parentCollection, int index)
        {
            if (node == null) return;

            node.Name = node.Text;

            nodeMap[node.Name] = node;
            parentMap[node.Name] = new NodeInfo(parentCollection, index);

            for (int i = 0; i < node.Nodes.Count; i++)
            {
                LoadNodeRecursive(node.Nodes[i], node.Nodes, i);
            }
        }

        public void InsertNode(string parentKey, string nodeKey, string text)
        {
            if (nodeMap.ContainsKey(nodeKey))
                return; // Avoid duplicate keys

            TreeNode newNode = new TreeNode(text) { Name = nodeKey };
            nodeMap[nodeKey] = newNode;

            if (string.IsNullOrEmpty(parentKey))  // Root node
            {
                m_treeView.Nodes.Add(newNode);
                parentMap[nodeKey] = new NodeInfo(m_treeView.Nodes, m_treeView.Nodes.Count - 1);
            }
            else if (nodeMap.TryGetValue(parentKey, out TreeNode parentNode))
            {
                parentNode.Nodes.Add(newNode);
                parentMap[nodeKey] = new NodeInfo(parentNode.Nodes, parentNode.Nodes.Count - 1);
            }
        }

        public bool RemoveNode(string nodeKey)
        {
            if (nodeMap.TryGetValue(nodeKey, out TreeNode node))
            {
                if (parentMap.TryGetValue(nodeKey, out NodeInfo parentInfo))
                {
                    int index = parentInfo.Parent.IndexOf(node);
                    parentMap[nodeKey] = new NodeInfo(parentInfo.Parent, index); // Preserve index
                }

                parentMap[nodeKey].Parent.Remove(node);
                nodeMap.Remove(nodeKey);

                return true;
            }
            return false;
        }

        public bool RestoreNode(string nodeKey)
        {
            if (parentMap.TryGetValue(nodeKey, out NodeInfo parentInfo) && !nodeMap.ContainsKey(nodeKey))
            {
                TreeNode newNode = new TreeNode(nodeKey) { Name = nodeKey, Text = nodeKey };

                if (parentInfo.Index >= 0 && parentInfo.Index < parentInfo.Parent.Count)
                    parentInfo.Parent.Insert(parentInfo.Index, newNode);
                else
                    parentInfo.Parent.Add(newNode); // Fallback to end

                nodeMap[nodeKey] = newNode;
                return true;
            }
            return false;
        }

        public bool ReplaceNode(string nodeKey, TreeNode newNode)
        {
            if (newNode == null || string.IsNullOrEmpty(newNode.Name))
                return false; // Ensure new node has a valid name

            if (nodeMap.TryGetValue(nodeKey, out TreeNode oldNode))
            {
                if (parentMap.TryGetValue(nodeKey, out NodeInfo parentInfo))
                {
                    int index = parentInfo.Parent.IndexOf(oldNode);
                    parentInfo.Parent.RemoveAt(index);
                    parentInfo.Parent.Insert(index, newNode);

                    // Update maps
                    nodeMap.Remove(nodeKey);
                    parentMap.Remove(nodeKey);

                    nodeMap[newNode.Name] = newNode;
                    parentMap[newNode.Name] = new NodeInfo(parentInfo.Parent, index);

                    return true;
                }
            }
            return false;
        }

        public bool InsertChildAfter(string parentKey, string afterChildKey, TreeNode newNode)
        {
            if (newNode == null || string.IsNullOrEmpty(newNode.Name))
                return false; // Ensure new node has a valid name

            if (!nodeMap.TryGetValue(parentKey, out TreeNode parentNode))
                return false; // Parent not found

            TreeNodeCollection children = parentNode.Nodes;

            int insertIndex = 0; // Default: Add as the first child
            if (!string.IsNullOrEmpty(afterChildKey) && nodeMap.TryGetValue(afterChildKey, out TreeNode afterChildNode))
            {
                insertIndex = children.IndexOf(afterChildNode) + 1; // Insert after this child
            }

            children.Insert(insertIndex, newNode);

            // Update maps
            nodeMap[newNode.Name] = newNode;
            parentMap[newNode.Name] = new NodeInfo(children, insertIndex);

            return true;
        }

        // Insert a node before the specified child node
        public bool InsertChildBefore(string parentKey, string beforeChildKey, TreeNode newNode)
        {
            if (newNode == null || string.IsNullOrEmpty(newNode.Name))
                return false; // Ensure new node has a valid name

            if (!nodeMap.TryGetValue(parentKey, out TreeNode parentNode))
                return false; // Parent not found

            TreeNodeCollection children = parentNode.Nodes;

            int insertIndex = 0; // Default: Add as the first child
            if (!string.IsNullOrEmpty(beforeChildKey) && nodeMap.TryGetValue(beforeChildKey, out TreeNode beforeChildNode))
            {
                insertIndex = children.IndexOf(beforeChildNode); // Insert before this child
            }

            children.Insert(insertIndex, newNode);

            // Update maps
            nodeMap[newNode.Name] = newNode;
            parentMap[newNode.Name] = new NodeInfo(children, insertIndex);

            return true;
        }

        public TreeNode GetNode(string nodeKey) => nodeMap.TryGetValue(nodeKey, out TreeNode node) ? node : null;
        public void ExpandAll() => m_treeView.ExpandAll();
        public void CollapseAll() => m_treeView.CollapseAll();
    }
}
