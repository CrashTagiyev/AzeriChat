using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bogus;
using Bogus.DataSets;

namespace AzeriChat
{
    public static class UserGrab
    {
        public static User? TempUser { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User>? Users { get; set; }
        public MainWindow()
        {
            try
            {

                InitializeComponent();
                DataContext = this;

                Users = new Faker<User>()
                   .RuleFor(u => u.Name, faker => faker.Person.FirstName)
                   .RuleFor(u => u.Surname, faker => faker.Person.LastName)
                   .RuleFor(u => u.Phone, faker => faker.Person.Phone.ToString())
                   .RuleFor(u => u.ImageUrl, faker => faker.Image.PicsumUrl())
                   .RuleFor(u => u.Birthday, faker => faker.Person.DateOfBirth).Generate(10);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }








        private void Send_Message_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button? button = sender as Button;
                //StackPanel? stackPanel = button?.Content as StackPanel;
                //TextBlock? usersChatBox = stackPanel?.FindName("Users_ChatBox") as TextBlock;
                TextBlock? textBlockRB2 = Chat_TextBlock?.FindName("Chat_TextBlock") as TextBlock;
                textBlockRB2.Text +=$"{DateTime.Now.ToShortTimeString()}\n"+ Write_Message_Button?.Text+"\n\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void Users_Listbox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {


                //Image TempImage =sp.Children[0]  as Image;
                //Image_RightBlock.Source = TempImage.Source;
                //// Access the child elements by their names
                //Image? image = stackPanel?.FindName("Buttons_Image") as Image;
                //TextBlock? ListTextBox1 = stackPanel?.FindName("List_TextBox1") as TextBlock;
                //TextBlock? ListTextBox2 = stackPanel?.FindName("List_TextBox2") as TextBlock;

                //Image? RBImage = Right_Block_ChildSP?.FindName("Image_RightBlock") as Image;
                //RBImage.Source = image?.Source;

                TextBox_RightBlock1.Text = Users[Users_Listbox.SelectedIndex].Name;
                TextBox_RightBlock2.Text = Users[Users_Listbox.SelectedIndex].Surname;


            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);
            }

        }
    }


}
