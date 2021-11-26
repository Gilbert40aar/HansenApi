using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Models
{
    public class JWTSettingsModel
    {
        public string SecretKey { get; set; } //Secret Key, dette er den ultimative sikkerhedsnøgle som er en det af den token som
                                              //bliver sendt, og det er med til at identificere om denne token er godkendt a denne
                                              //api
    }
}
