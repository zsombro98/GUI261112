namespace GUI261112;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        add_item.Click += Add_item_Click;
        clear.Click += Clear_Click;
        clear_all.Click += Clear_all_Click;
    }

    private void Clear_all_Click(object? sender, EventArgs e)
    {
        list_items.Items.Clear();
    }

    private void Clear_Click(object? sender, EventArgs e)
    {
        list_items.Items.Remove(list_items.SelectedItem);
    }

    private void Add_item_Click(object? sender, EventArgs e)
    {
        list_items.Items.Add(txtbox.Text);
    }

    private void txtbox_TextChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
