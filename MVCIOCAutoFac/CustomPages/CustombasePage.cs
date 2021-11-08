using System.Web.Mvc;
using MVCIOCAutoFac.Repositories;

namespace MVCIOCAutoFac.CustomPages
{
    public class CustombasePage : WebViewPage
    {
        public IDataRepository DataRepository { get; set; }
        public override void Execute()
        {
        }
    }
}