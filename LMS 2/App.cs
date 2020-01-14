using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_2
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext selectALl = new DataClasses1DataContext();
            dataGridView1.DataSource = selectALl.selectAllBooks();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext selectById = new DataClasses1DataContext();
            dataGridView1.DataSource = selectById.selectBookById(int.Parse(textBox1.Text));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext insertBook = new DataClasses1DataContext();
            insertBook.insertNewBook(bookTitleBox.Text, bookAuthorBox.Text, double.Parse(bookPriceBox.Text, CultureInfo.InvariantCulture), comboBox1.Text, int.Parse(bookPublisherIdBox.Text));
            MessageBox.Show($"Book *{bookTitleBox.Text}* is added successfuly");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext deleteBook = new DataClasses1DataContext();
            deleteBook.deleteBookById(int.Parse(bookIdtoDeleteBox.Text));
            MessageBox.Show("Book is deleted successfuly");
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext selectAllPublishers = new DataClasses1DataContext();
            dataGridView2.DataSource = selectAllPublishers.selectAllPublishers();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext selectPublisherById = new DataClasses1DataContext();
            dataGridView2.DataSource = selectPublisherById.selectPublisherById(int.Parse(publisherIdBox.Text));
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext insertPublisher = new DataClasses1DataContext();
            insertPublisher.insertNewPublisher(publisherNameBox.Text, publisherAddressBox.Text);
            MessageBox.Show($"Publisher *{publisherNameBox.Text}* is added successfuly");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext deletePublisher = new DataClasses1DataContext();
            deletePublisher.deletePublisherById(int.Parse(publisherIdtoDeleteBox.Text));
            MessageBox.Show("Publisher is deleted successfuly");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext selectAllMembers = new DataClasses1DataContext();
            dataGridView3.DataSource = selectAllMembers.selectAllMembers();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext selectMemberById = new DataClasses1DataContext();
            dataGridView3.DataSource = selectMemberById.selectMemberById(int.Parse(memberIdBox.Text));
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext insertMember = new DataClasses1DataContext();
            insertMember.insertNewMember(memberNameBox.Text, memberAddressBox.Text, dateTimePicker1.Value, dateTimePicker2.Value);
            MessageBox.Show($"Member *{memberNameBox.Text}* is added successfuly");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            DataClasses1DataContext deleteMember = new DataClasses1DataContext();
            deleteMember.deleteMemberById(int.Parse(memberIdtoDeleteBox.Text));
            MessageBox.Show("Member is deleted successfuly");
        }

        
    }
}
