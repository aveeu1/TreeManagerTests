using ATP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        TreeViewManager m_treeViewManager = null;
        public Form1()
        {
            InitializeComponent();

           

            TreeNode root = new TreeNode("TestList");
            TreeNode child1 = new TreeNode("Child1");
            TreeNode child2 = new TreeNode("Child2");
            TreeNode child3 = new TreeNode("Child3");
            TreeNode child4 = new TreeNode("Child4");
            TreeNode child5 = new TreeNode("Child5");

            root.Nodes.AddRange(new TreeNode[] { child1, child2,child3,child4,child5});

            treeView1.Nodes.Add(root);

            m_treeViewManager = new TreeViewManager(treeView1);

            m_treeViewManager.ExpandAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                m_treeViewManager.InsertNode("TestList", textBoxInsertChildName.Text, textBoxInsertChildName.Text);

                m_treeViewManager.ExpandAll();
            }
            catch(Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ShowError(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!m_treeViewManager.RemoveNode(textBoxRemoveChildName.Text))
                    throw new Exception("Node removal failed!");

                m_treeViewManager.ExpandAll();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }          
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                string newText = textBoxNewChildName.Text;

                string nodeKey = textBoxOldChildName.Text;

                TreeNode newNode = new TreeNode(newText) { Text = newText ,Name = newText};

                if (!m_treeViewManager.ReplaceNode(nodeKey, newNode))
                    throw new Exception("Node replacement failed!");

                m_treeViewManager.ExpandAll();
            }
            catch(Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (!m_treeViewManager.RestoreNode(textBoxInsertChildName.Text))
                    throw new Exception("Node restoration failed!");

                m_treeViewManager.ExpandAll();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnInsertAfter_Click(object sender, EventArgs e)
        {
            try
            {
                string newText = textBoxInsertAfter.Text;

                string targetChildName = textBoxTargetChild.Text;

                string newNodeKey = newText; 

                TreeNode newNode = new TreeNode(newText) { Text = newText, Name= newNodeKey };

                if (!m_treeViewManager.InsertChildAfter("TestList", targetChildName, newNode))
                    throw new Exception("Insertion after targeted child failed!");

                m_treeViewManager.ExpandAll();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnInsertBefore_Click(object sender, EventArgs e)
        {
            try
            {
                string newText = textBoxInsertBefore.Text;

                string targetChildName = textBoxTargetChild.Text;

                string newNodeKey = newText;

                TreeNode newNode = new TreeNode(newText) { Text = newText, Name = newNodeKey };

                if (!m_treeViewManager.InsertChildBefore("TestList", targetChildName, newNode))
                    throw new Exception("Insertion after targeted child failed!");

                m_treeViewManager.ExpandAll();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
