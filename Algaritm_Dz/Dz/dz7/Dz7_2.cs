using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz7
{//72. Написать рекурсивную функцию обхода графа в глубину.
    class Dz7_2
    {

        public class Node
        {
            public bool flag = false;
            public int key;
            public Node left, right , back;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }


        Node root;


        Dz7_2()
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
            {
                root.left.back = root;
                root.left = insertRec(root.left, key);
            }
               
            
            else if (key > root.key)
            {
                root.right.back = root;
                root.right = insertRec(root.right, key);
            }
                

            return root;
        }
        Node search(Node root, int key)
        {
            if(root.left.key > root.right.key && root.left.flag != true)
            {
                root.right.flag = true;
                root = search(root.left, key);
            }
            if (root.left.key < root.right.key && root.right.flag != true)
            {
                root.left.flag = true;
                root = search(root.right, key);
            }
            if (key < root.key)
            {
                if (root.left == null)
                    Console.WriteLine("НЕТ ТАКОГО УЗЛА");
                root = search(root.left, key);
            }

            else if (key > root.key)
            {
                if (root.left == null)
                    Console.WriteLine("НЕТ ТАКОГО УЗЛА");
                root = search(root.right, key);
            }
            //if(root.left = null && root.right = null)
            //{
            //    root = search(root.back, key);
            //}
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
            Dz7_2 tree = new Dz7_2();


           

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
            Console.WriteLine(" Нашелся узел " + finish);
            Console.ReadKey();
        }
    }
}

