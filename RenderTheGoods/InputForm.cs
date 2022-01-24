using RenderTheGoods.Logic;
using RenderTheGoods.Models;

namespace RenderTheGoods
{
    public partial class InputForm : Form
    {
        private readonly IRectangleRepository _rectangleRepository;
       

        public InputForm(IRectangleRepository rectangleRepository)
        {
            InitializeComponent();
            _rectangleRepository = rectangleRepository; 
        }
        public List<RectangleModel> _inputRectangles { get; set; }
        public List<RectangleModel> _outputRectangles { get; set; }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            InputDto inputDto = new InputDto();
            inputDto.NumberOfRectangles = Convert.ToInt32(nudNumofRectangles.Text);


            _inputRectangles = _rectangleRepository.GenerateRectanglesHorizontally(inputDto);
        
            if (_inputRectangles.Count == 0)
            {
                MessageBox.Show("Unable to return requested rectangles");
            }
            else
            {
                _outputRectangles = _rectangleRepository.GenerateRectanglesVertically(_inputRectangles);

                pnlDisplay.Invalidate();
                pnlDisplayOutput.Invalidate();
            }


        }

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {
            if (_inputRectangles != null)
            {
                SolidBrush myBrush = new System.Drawing.SolidBrush(Color.White);
                var rc = this.ClientRectangle;
                rc.Inflate(-2, -2);
                //e.Graphics.ScaleTransform(1.0F, -1.0F);
                e.Graphics.ScaleTransform(1, -1);
                e.Graphics.TranslateTransform(0, -pnlDisplay.Height);
                foreach (RectangleModel rectangleModel in _inputRectangles)
                {

                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(rectangleModel.Position.X, rectangleModel.Position.Y, rectangleModel.Width, rectangleModel.Height));

                }
            }
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlDisplayOutput_Paint(object sender, PaintEventArgs e)
        {
            if (_outputRectangles != null)
            {
                SolidBrush myBrush = new System.Drawing.SolidBrush(Color.White);
                var rc = this.ClientRectangle;
                rc.Inflate(-2, -2);
                //e.Graphics.ScaleTransform(1.0F, -1.0F);
                e.Graphics.ScaleTransform(1, -1);
                e.Graphics.TranslateTransform(0, -pnlDisplay.Height);
                foreach (RectangleModel rectangleModel in _outputRectangles)
                {

                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(rectangleModel.Position.X, rectangleModel.Position.Y, rectangleModel.Width, rectangleModel.Height));

                }
            }
        }
    }
}