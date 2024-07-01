using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Shaded.Protobuf;
using Xamarin.KotlinX.Coroutines;

namespace EvaluacionRengifo.Datos
{
    internal class ApiConsumo
    {

        public string created_at {  get; set; }
        public UrlWebViewSource icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public UrlWebViewSource url {  get; set; }
        public string joke { get; set; }

        

        public void showJoke(Label _chiste,Button _action) {

            this.joke = "teste";

            
        }
    }
}
