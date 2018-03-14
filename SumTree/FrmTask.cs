using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumTree
{
    public partial class frmTask : Form
    {
        string _goldenBranch = "";
        Int32 _greatestSum = 0;
        
        public frmTask()
        {
            InitializeComponent();
            RunTask();
        }

        private void RunTask()
        {
            // input from task pdf:
            string sTree = @"215
                            192 124
                            117 269 442
                            218 836 347 235
                            320 805 522 417 345
                            229 601 728 835 133 124
                            248 202 277 433 207 263 257
                            359 464 504 528 516 716 871 182
                            461 441 426 656 863 560 380 171 923
                            381 348 573 533 448 632 387 176 975 449
                            223 711 445 645 245 543 931 532 937 541 444
                            330 131 333 928 376 733 017 778 839 168 197 197
                            131 171 522 137 217 224 291 413 528 520 227 229 928
                            223 626 034 683 839 052 627 310 713 999 629 817 410 121
                            924 622 911 233 325 139 721 218 253 223 107 233 230 124 233";
            // visualisation of input:
            string[] saTree = Regex.Split(sTree,"\r\n");
            StringBuilder sbTree = new StringBuilder();
            foreach (string sLine in saTree)
            {
                sbTree.AppendLine(sLine.Trim());
            }
            rtTree.Text = sbTree.ToString();

            // Find branch with greatest sum:
            Recalc();
        }

        private void cbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbRefresh_Click(object sender, EventArgs e)
        {
            Recalc();
        }

        private void AddChildren(TreeNode node,string[] saRows,int pnRow,int pnCol,string psBranch)
        {
            //node - current node looking for children
            //saRows - string array with input values
            //pnRow - row number of the current node
            //pnCol - col number of the current node
            //psBranch - branch as string of comma separated input values till the current node point (current node included)

            //Add proper values from the next row to the current node as children

            //current node value as string
            string sNode = node.Text;

            // taking next row
            int nRow = pnRow + 1;
            int nCol = pnCol;

            int nVal = int.Parse(sNode);
            string sNextRow = saRows[nRow];
            // iterate through current (moving down from the current node) and next (moving diagonal from the current node) column
            for (int i = 0; i < 2; i++)
            {
                string sBranch = psBranch;
                nCol = nCol + i;
                //taking input value of current or next column 
                string sEl = (sNextRow.Split(' ')[nCol]).Trim();
                int nElVal = int.Parse(sEl);

                //checking if nVal (currenct node value) and nElVal (candidate node value) are different (one - even, another - odd)
                if ((nVal + nElVal) % 2 == 1)
                {
                    // proper value, adding as child
                    TreeNode nodeNew = node.Nodes.Add(nElVal.ToString());

                    // extending branch with proper value
                    sBranch = sBranch + "," + sEl;

                    if (nRow < saRows.Length - 2)
                    {
                        // not the deepest level, looking further for childnodes
                        AddChildren(nodeNew, saRows, nRow, nCol, sBranch);
                    }
                    else //deepest level reached
                    {
                        //sum branch values
                        Int32 nBranchSum = SumBranch(sBranch);

                        //logging full branch to visualise results
                        rtBranches.Text = rtBranches.Text + sBranch + " (" + nBranchSum.ToString() + ")" + Environment.NewLine;

                        if (nBranchSum > _greatestSum)
                        {
                            // this branch has greater sum as the last known. Assigning it to the "goldenBranch"
                            _goldenBranch = sBranch;
                            _greatestSum = nBranchSum;
                        }
                    }
                }
            }
        }

        private void Recalc()
        {
            //reset calculations (just richText rtTree is kept as input)
            tvTree.Nodes.Clear();
            _goldenBranch = "";
            _greatestSum = 0;
            rtBranches.Text = "";

            //proceed with input
            string[] saRows = Regex.Split(rtTree.Text, "\n");

            // start with first line's value
            string sNode = saRows[0].Trim();
            TreeNode node = tvTree.Nodes.Add(sNode);

            // add child nodes
            AddChildren(node, saRows, 0, 0, sNode);

            // show result
            lRes.Text = "The branch with greatest sum (" + _greatestSum.ToString() + ") - " + _goldenBranch;
        }

        private Int32 SumBranch(string sBranch)
        {
            // sum branch values
            Int32 nRet = 0;
            string[] saVals = sBranch.Split(',');
            foreach (string sVal in saVals)
            {
                nRet = nRet + Int32.Parse(sVal.Trim());
            }
            return nRet;
        }

    }
}
