using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sets;
using Resource;
using Data_Structure_Project;
using System.IO;

namespace NewGUI
{
    public partial class Form1 : Form
    {
        ArraySet[] setList;
        int setCount=0;
        public Form1()
        {
            setList = new ArraySet[10];
            InitializeComponent();
        }
        private int getIndexFromChar(char c)
        {
            char[,] table = { { '0', 'A' }, { '1', 'B' }, { '2', 'C' }, { '3', 'D' } , { '4', 'E' }, { '5', 'F' }, { '6', 'G' }, { '7', 'H' },{ '8','I'} , { '9', 'J' } };
            try
            {
                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i, 1] == c)
                    {
                        return int.Parse(Convert.ToString(table[i, 0]));
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                return -1;
            }

                return -1;

        }
        private bool isValidated(String str)
        {
            return true;
        }
        private bool isCorrectFormat(String e)
        {
            if (e.Length == 0) return true;
            else if (e[0] == ' ') return false;
            foreach (char i in e.ToCharArray())
                if (i == '1' || i == '2' || i == '3' || i == '4' || i == '5' || i == '6' || i == '7' || i == '8' || i == '9' || i == '0' || i == ' ' || i == '.' || i == '-') ;
                else return false;
            return true;
        }
        private void InsertSetButt_Click(object sender, EventArgs e)
        {
            if (setCount < 10 && SetName.Text != "")
            {
                try
                {
                    int index = getIndexFromChar(char.Parse(SetName.Text));
                    if (index == -1)
                    {
                        NotifLabel.Text = "Set Name is Incorrect. try to insert A-J";
                        return;
                    }
                    ArraySet set = new ArraySet();
                    if (setList[index] == null && isCorrectFormat(SetValue.Text))
                    {
                        setList[index] = set; //add
                        setCount++;
                        if (!SetValue.Text.Equals(""))
                            setList[index].addString(SetValue.Text);
                        NotifLabel.Text = "Insert set " + SetName.Text + " successfully";
                        listBox1.Items.Add(SetName.Text + " : " + set.toString());
                        NotifLabel.ForeColor = Color.Green;
                    }
                    else if (setList[index] != null)
                    {
                        NotifLabel.Text = "Set " + SetName.Text + " is already exist";
                        NotifLabel.ForeColor = Color.Red;
                    }
                    else if (!isCorrectFormat(SetValue.Text))
                    {
                        NotifLabel.Text = "Set Element is not in a correct format";
                        NotifLabel.ForeColor = Color.Red;
                    }
                }
                catch (Exception)
                {
                    NotifLabel.Text = "Incorrect Input";
                }
            }
            else if (setCount >= 10)
            {
                NotifLabel.Text = "Set is Full";
                NotifLabel.ForeColor = Color.Purple;
            }
            else
                NotifLabel.Text = "Error";
        }

        private void CalculateButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (UnionRad.Checked)
                    if (!InfixBox.Text.Equals(""))
                    {
                        String infix = InfixBox.Text;
                        String posfix = Postfix.ConvertToPostFix(infix);
                        ArraySet res = UnionAndIntersResult(posfix);
                        ResultBox.Text = res.toString();
                    }

                if (PowerSetRad.Checked)
                {
                    ArraySet res = UnionAndIntersResult(Postfix.ConvertToPostFix(InfixBox.Text));
                    ResultBox.Text = ArraySet.getPowerSet(res);
                }
                if (SubSetRad.Checked)
                {
                    String expression = InfixBox.Text;
                    String temp = "";
                    ArraySet temp1 = null;
                    ArraySet temp2;
                    foreach (char i in expression.ToCharArray())
                    {
                        if (i == 'c')
                        {
                            temp1 = UnionAndIntersResult(Postfix.ConvertToPostFix(temp));
                            temp = "";
                        }
                        else
                            temp += i;
                    }
                    temp2 = UnionAndIntersResult(Postfix.ConvertToPostFix(temp));
                    ResultBox.Text = Convert.ToString(ArraySet.isSubsetOf(temp1, temp2));

                }
                if(CartesianRad.Checked)
                {
                    String expression = InfixBox.Text;
                    expression = expression.Replace('(', ' ');
                    expression = expression.Replace(')', ' ');
                    expression = expression.Replace('x', ' ');
                    int count = 0;
                    foreach (char i in expression.ToArray())
                        if (getIndexFromChar(i) != -1)
                            count++;
                    ArraySet[] tempSetList= new ArraySet[count];
                    count = 0;
                    foreach(char i in expression.ToArray())
                    {
                        if (getIndexFromChar(i) != -1)
                        {
                            tempSetList[count] = setList[getIndexFromChar(i)];
                            if (tempSetList[count].size() == 0)
                            {
                                ResultBox.Text = "Error : Cartesian product with an empty set";
                                return;
                            }
                            count++;
                        }
                    }
                    ResultBox.Text = ArraySet.Cartesian(tempSetList);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error : Incorrect Input"+" : "+ex.Message);
            }
        }
        private ArraySet UnionAndIntersResult(String posfix)
        {
            Stack<ArraySet> stack = new Stack<ArraySet>();
            foreach (char c in posfix.ToCharArray())
            {
                if (c == 'U'||c == 'u')
                {
                    ArraySet resultTemp = stack.Pop().Union(stack.Pop());
                    stack.Push(resultTemp);
                    
                }
                else if (c == 'n')
                {
                    ArraySet resultTemp = stack.Pop().intersection(stack.Pop());
                    stack.Push(resultTemp);
                }
                else if (c == '-')
                {
                    ArraySet resultTempB = stack.Pop();
                    ArraySet resultTempA = stack.Pop();
                    stack.Push(resultTempA.difference(resultTempB));
                }
                else
                {
                    ArraySet temp1 = setList[getIndexFromChar(c)];
                    stack.Push(temp1);
                }
            }
            return stack.Pop();
        }
        private int NOECalculate(ArraySet[] data,String infix)
        {
            int check = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0;i < infix.Length;i++)
            {
                if (infix[i] == '+')
                {
                        stack.Push(stack.Pop() + stack.Pop());
                        check = 0;
                }
                else if (infix[i] == '-')
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b - a);
                        check = 0;
                }
                else
                {
                    stack.Push(data[int.Parse(Convert.ToString(infix[i]))].size());
                    check++;
                } 
                
            }
            if (stack.Count != 0)
                return stack.Pop();
            else return -1;
        }
        private void DeleteButt_Click(object sender, EventArgs e)
        {
            if (setList[getIndexFromChar(char.Parse(DeleteBox.Text))] != null)
            {
                setList[getIndexFromChar(char.Parse(DeleteBox.Text))] = null;
                NotifLabel.Text = "Delete Set " + DeleteBox.Text + " Successfully";
                int index = listBox1.FindString(DeleteBox.Text);
                if (index >= 0)
                    listBox1.Items.RemoveAt(index);
            }
            else NotifLabel.Text = "Set " + DeleteBox.Text + " doesn't exist";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ClearResultButt_Click(object sender, EventArgs e)
        {
            SetName.Text = SetValue.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
