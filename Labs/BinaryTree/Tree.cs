﻿using System;

namespace BinaryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }
        public Tree(TItem nodeValue)
        {
            NodeData = nodeValue;
            LeftTree = null;
            RightTree = null;
        }
        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (LeftTree == null)
                    LeftTree = new Tree<TItem>(newItem);
                else
                    LeftTree.Insert(newItem);
            }
            else
            {
                if (RightTree == null)
                    RightTree = new Tree<TItem>(newItem);
                else
                    RightTree.Insert(newItem);
            }
        }
        public string WalkTree()
        {
            string result = "";
            if (LeftTree != null)
                result = LeftTree.WalkTree();
            result += $" {NodeData.ToString()} ";
            if (RightTree != null)
                result += RightTree.WalkTree();
            return result;
        }
    }
}
