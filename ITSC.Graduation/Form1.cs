using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace ITSC.Graduation
{
    public partial class Form1 : Form
    {
        private List<StudentInfo> students;
        private int studentsIndex = 0;
        private SpeechSynthesizer synth = new SpeechSynthesizer();
        private Random random = new Random();

        string studentsList = "students.txt";

        public Form1()
        {
            InitializeComponent();

            CultureInfo spanishCulture = new CultureInfo("en");
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, spanishCulture);

            foreach (InstalledVoice voice in synth.GetInstalledVoices())
            {
                if (voice.VoiceInfo.Culture.Name == "es-ES")
                {
                    synth.SelectVoice(voice.VoiceInfo.Name);
                    break;
                }
            }

            string executionPath = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = Path.Combine(executionPath, studentsList);

            lblFullName.Text = string.Empty;
            lblCareer.Text = string.Empty;

            LoadDataFromPath(fullPath);
            ReadCurrentStudent();
        }

        private void LoadDataFromPath(string rutaArchivo)
        {
            students = new List<StudentInfo>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] parts = linea.Split(',');
                        if (parts.Length >= 2)
                        {
                            string fullname = parts[0];
                            string profession = parts[1];
                            string merit = parts[2];

                            students.Add(new StudentInfo(fullname, profession, merit));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el archivo: {ex.Message}");
            }
        }

        private void ReadCurrentStudent()
        {
            if (studentsIndex < students.Count)
            {
                StudentInfo estudianteActual = students[studentsIndex];
                var speach = $"{estudianteActual.FullName}. {estudianteActual.Profession}.";
                if (!string.IsNullOrEmpty(estudianteActual.Merit))
                {
                    speach += $" {estudianteActual.Merit}";
                }

                synth.SpeakAsync(speach);

                if (synth.Voice.Culture.Name == "es-ES")
                {
                    //synth.SpeakAsync($"{estudianteActual.Nombre}. {estudianteActual.Profesion}.");
                }

                lblFullName.Text = estudianteActual.FullName;
                lblCareer.Text = estudianteActual.Profession;

                SimulateRandomSelection();

                studentsIndex++;

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 7000; // 5 segundos
                timer.Tick += (sender, e) =>
                {
                    timer.Stop();
                    ReadCurrentStudent();
                };
                timer.Start();
            }
        }

        private void SimulateRandomSelection()
        {
            pictureBox1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                LoadDataFromPath(rutaArchivo);
                ReadCurrentStudent();
            }
        }
    }
}

class StudentInfo
{
    public string FullName { get; set; }
    public string Profession { get; set; }
    public string Merit { get; set; }

    public StudentInfo(string nombre, string profesion, string merit)
    {
        FullName = nombre;
        Profession = profesion;
        Merit = merit;
    }
}
