using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz6
{//2. Переписать программу, реализующую двоичное дерево поиска.
   
public class Dz6_2
        {

        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }


        Node root;


        Dz6_2()
        {
            root = null;
        }


        void insert(int key)
        {
            root = insertRec(root, key);
        }
        int Search(int key)
        {
            root = search(root, key);
            return root.key;
        }


        Node insertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);

            return root;
        }
         Node search(Node root, int key)
        {

            if (key < root.key)
            {
                if(root.left==null)
                    Console.WriteLine("НЕТ ТАКОГО УЗЛА");
               root = search(root.left, key);
            }
                 
            else if (key > root.key)
            {
                if (root.left == null)
                    Console.WriteLine("НЕТ ТАКОГО УЗЛА");
              root =  search(root.right, key);
            }
                
            else if (key == root.key) return root;
            return root;
        }

        void inorder()
        {
            inorderRec(root);
        }

        void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            }
        }


        public static void Start()
        {
            Dz6_2 tree = new Dz6_2(); 
           

            /* 
                  50
               /     \
              30      70
             /  \    /  \
           20   40  60   80 */

            tree.insert(50);
            tree.insert(30);
            tree.insert(20);
            tree.insert(40);
            tree.insert(70);
            tree.insert(60);
            tree.insert(80);

            tree.inorder();
            Console.WriteLine("Видите число для поиска в дереве");
            int Number = int.Parse(Console.ReadLine());

            int finish = tree.Search(Number);
            Console.WriteLine(" Нашелся узел "+finish);
            Console.ReadKey();
        }
    }
}
