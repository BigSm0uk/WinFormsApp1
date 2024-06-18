using Microsoft.EntityFrameworkCore;
using WinFormsApp1.DataAccess;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _context.InitDb();

            InitDataGrid();

            treeView1.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(treeView1_AfterSelect);

        }

        private void InitDataGrid()
        {
            var mes = _context.Mesures.Select(me => me).ToList();

            dataGridView1.DataSource = mes;
        }
        private void treeView1_AfterSelect(object sender, TreeNodeMouseClickEventArgs e)
        {
            // �������� ��������� ����
            TreeNode selectedNode = e.Node;

            // ������� ����� ���������� ���� � ������� (��� ����������� ��� �� ������ ����������)
            MessageBox.Show("��������� ����: " + selectedNode.Text);
        }


    }
}
