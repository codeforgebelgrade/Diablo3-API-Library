using System.Windows;
using Codeforge.Diablo3InfoClasses;
using Codeforge.Diablo3Info;
using Newtonsoft.Json;

namespace Diablo3APIDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// This project serves simply as a demo project - an example showing how to use the library
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSendProfileRequest_Click(object sender, RoutedEventArgs e)
        {
            tbJsonResponse.Clear();
            ProfileInfo profileInfoResponse = DiabloService.GetProfileInfo(RequestParameters.REGIONS.EU, tbBattleTag.Text, "en_GB", tbApiKey.Text);
            string output = JsonConvert.SerializeObject(profileInfoResponse, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            tbJsonResponse.Text = output; 
        }

        private void btnSendCharacterRequest_Click(object sender, RoutedEventArgs e)
        {
            tbJsonResponse.Clear();
            CharacterInfo charInfoResponse = DiabloService.GetCharacterInfo(RequestParameters.REGIONS.EU, tbBattleTag.Text, tbHeroId.Text, "en_GB", tbApiKey.Text);
            string output = JsonConvert.SerializeObject(charInfoResponse, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            tbJsonResponse.Text = output;
        }

        private void btnSendArtisanRequest_Click(object sender, RoutedEventArgs e)
        {
            tbJsonResponse.Clear();
            ArtisanInfo artisanInfoResponse = DiabloService.GetArtisanInfo(RequestParameters.REGIONS.EU, RequestParameters.ARTISANS.BLACKSMITH, "en_GB", tbApiKey.Text);
            string output = JsonConvert.SerializeObject(artisanInfoResponse, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            tbJsonResponse.Text = output;
        }

        private void btnSendFollowerRequest_Click(object sender, RoutedEventArgs e)
        {
            tbJsonResponse.Clear();
            FollowerInfo followerInfoResponse = DiabloService.GetFollowerInfo(RequestParameters.REGIONS.EU, RequestParameters.FOLLOWERS.TEMPLAR, "en_GB", tbApiKey.Text);
            string output = JsonConvert.SerializeObject(followerInfoResponse, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            tbJsonResponse.Text = output;
        }
    }
}
