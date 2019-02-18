using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBot
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "aVxapoXb9denVBKfWil7D/Sl9tR9uAHT7QZkckfNHcFZu8GafbGbQpMjP+0ufrVZIWRb2RrKgRDGpf2bYk4AGtdbINiDljNbzp+ZP6XkDsZ9NcY/mqwqw+2C2eSMjbdyJwQgjkUFAZjaW+jiDixmcgdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "Uc0f0a7453fd835cc9fbf385597c86582";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}