using Entidades;
namespace FrmView
{
    public partial class FrmView : Form
    {

        Partido tandaPenales;

        public FrmView()
        {
            InitializeComponent();

            Equipo bocaJrs = new Equipo("Boca Juniors");
            Equipo fluminense = new Equipo("Fluminense");

            bocaJrs.ImgGanador = @"https://fotos.perfil.com/2017/06/01/trim/720/410/0620-boca-libertadores2007-g.jpg";
            bocaJrs.ImgPerdedor = @"https://media.diariouno.com.ar/p/43b8fbeaebbd8d87f255f3e76d97f7ff/adjuntos/298/imagenes/009/127/0009127660/1200x0/smart/boca1jpg.jpg";
            bocaJrs.ImgPateando = @"https://www.ole.com.ar/2021/05/16/R3KXuHfzz_340x340__1.jpg";

            fluminense.ImgGanador = @"https://www.ole.com.ar/2023/11/04/38pEQUVb9_400x400__1.jpg";
            fluminense.ImgPerdedor = @"https://www.clarin.com/2023/11/04/I034TX9yJ_1256x620__1.jpg";
            fluminense.ImgPateando = @"https://www.ole.com.ar/images/2022/03/17/6jyx_mvCF_720x0__1.jpg";
            this.tandaPenales = new Partido(fluminense, bocaJrs, 5);

        }

        private void btnApretar_Click(object sender, EventArgs e)
        {


            this.tandaPenales.IniciarEnfrentamiento();


        }

        private void MostrarEmpate(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(()=> this.MostrarEmpate(mensaje));
            }
            else
            {
                this.lblEmpate.Visible = true;
                this.lblEmpate.Text = mensaje;
            }
      
        }

        private void MostrarGanador(Equipo ganador, Equipo perdedor)
        {
            if(this.InvokeRequired)
            {
                this.BeginInvoke(()=>this.MostrarGanador(ganador, perdedor));
            }
            else
            {
                this.pcbGanador.Load(ganador.ImgGanador);
                this.pcbPerdedor.Load(perdedor.ImgPerdedor);
            }

        }

        private void MostrarPateando(string mensaje, Equipo equipo)
        {
            if(this.InvokeRequired)
            {
                this.BeginInvoke(()=> this.MostrarPateando(mensaje, equipo));
            }
            else
            {
                this.lblPateando.Text = mensaje;
                this.pcbPateando.Load(equipo.ImgPateando);

            }


        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            this.tandaPenales.OnGanador += this.MostrarGanador;
            this.tandaPenales.OnEjecutor += this.MostrarPateando;
            this.tandaPenales.OnEmpate += this.MostrarEmpate;
        }
    }
}