using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class OfficeDesk : Form
    {
        public OfficeDesk()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, System.EventArgs e)
        {
            Utility.OpenForm(this, new Office());
        }

        private void nose_honk_button_Click(object sender, System.EventArgs e)
        {
            SoundController.Play(SoundType.NOSE_HONK);
        }

        private void paper1_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPaperToForm(this, "Une base de données est un ensemble d'informations qui " +
                                         "est organisé de manière à être facilement accessible, géré " +
                                         "et mis à jour. Elle est utilisée par les organisations comme " +
                                         "méthode de stockage, de gestion et de récupération de l’informations.\n\n" +
                                         "Les données sont organisées en lignes, colonnes et tableaux et sont " +
                                         "indexées pour faciliter la recherche d'informations.");
        }

        private void paper2_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPaperToForm(this, "Pour sortir de cette salle il vous faudra trouver un code " +
                                         "en triant les données dans les bonnes catégories.\n\n" +
                                         "Retenez bien qu'une donnée peut se trouver dans différentes catégories.");
        }

        private void paper3_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPaperToForm(this, "Feuille 3");
        }

        private void postit1_button_Click(object sender, System.EventArgs e)
        {
            Utility.AddPostItToForm(this, "Salut tout le monde c'est DavidLePoconmon" +
                                          "\nEt\nPomme\nDe\nTerre");
        }
    }
}