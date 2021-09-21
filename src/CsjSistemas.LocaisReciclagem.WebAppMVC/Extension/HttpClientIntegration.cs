using CsjSistemas.LocaisReciclagem.WebAppMVC.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.WebAppMVC.Extension
{
    public class HttpClientIntegration
    {
        public List<RespostaLocalReciclagemModel> Get(string url)
        {
            HttpWebResponse response;
            var lista = new List<RespostaLocalReciclagemModel>();

            if (Get(out response, url))
            {
                var json = ReadResponse(response);
                response.Close();
                var jsonResult = JsonConvert.DeserializeObject<JsonResultModel>(json);

                if (jsonResult.statusCode == "200")
                {
                    foreach (var item in jsonResult.value)
                    {
                        var model = new RespostaLocalReciclagemModel
                        {
                            description = $"{ item.logradouro} - {item.numeroEndereco} - {item.bairro} - {item.complemento} - Capacidade - {item.capacidade}",
                            id = item.localReciclagem_Id,
                            title = item.identificacao,
                            lat = item.latitude,
                            lng = item.longitude
                        };
                        lista.Add(model);
                    }
                }

                return lista;

            }
            return lista;
        }
        public void Post(string url, LocalReciclagemModel model, bool adicionar = false)
        {
            HttpWebResponse response;
            if (Post(out response, url, model, adicionar))
            {
                response.Close();
            }
        }
        private bool Get(out HttpWebResponse response, string url)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{url}");

                request.KeepAlive = true;
                request.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
                request.Headers.Add("sec-ch-ua", @"""Google Chrome"";v=""93"", "" Not;A Brand"";v=""99"", ""Chromium"";v=""93""");
                request.Headers.Add("sec-ch-ua-mobile", @"?0");
                request.Headers.Add("sec-ch-ua-platform", @"""Windows""");
                request.Headers.Add("Upgrade-Insecure-Requests", @"1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/93.0.4577.82 Safari/537.36";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                request.Headers.Add("Sec-Fetch-Site", @"none");
                request.Headers.Add("Sec-Fetch-Mode", @"navigate");
                request.Headers.Add("Sec-Fetch-User", @"?1");
                request.Headers.Add("Sec-Fetch-Dest", @"document");
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }


        private bool Post(out HttpWebResponse response, string url, LocalReciclagemModel modelbody, bool adicionar = false)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{url}");

                request.KeepAlive = true;
                request.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
                request.Headers.Add("sec-ch-ua", @"""Google Chrome"";v=""93"", "" Not;A Brand"";v=""99"", ""Chromium"";v=""93""");
                request.Headers.Add("sec-ch-ua-mobile", @"?0");
                request.Headers.Add("sec-ch-ua-platform", @"""Windows""");
                request.Headers.Add("Upgrade-Insecure-Requests", @"1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/93.0.4577.82 Safari/537.36";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                request.Headers.Add("Sec-Fetch-Site", @"none");
                request.Headers.Add("Sec-Fetch-Mode", @"navigate");
                request.Headers.Add("Sec-Fetch-User", @"?1");
                request.Headers.Add("Sec-Fetch-Dest", @"document");
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");

                request.Method = "POST";
                string body = string.Empty;
                if (adicionar)
                {
                    body = @$"Identificacao={modelbody.Identificacao}&CEP={modelbody.CEP}&Logradouro={modelbody.Logradouro}&NumeroEndereco={modelbody.NumeroEndereco}&Complemento={modelbody.Complemento}&Bairro={modelbody.Bairro}&Cidade={modelbody.Cidade}&Capacidade={modelbody.Capacidade}&Latitude={modelbody.Latitude}&Longitude={modelbody.Longitude}";
                }
                else
                {
                    body = @$"LocalReciclagem_Id={modelbody.LocalReciclagem_Id}&Identificacao={modelbody.Identificacao}&CEP={modelbody.CEP}&Logradouro={modelbody.Logradouro}&NumeroEndereco={modelbody.NumeroEndereco}&Complemento={modelbody.Complemento}&Bairro={modelbody.Bairro}&Cidade={modelbody.Cidade}&Capacidade={modelbody.Capacidade}&Latitude={modelbody.Latitude}&Longitude={modelbody.Longitude}";
                }

                byte[] postBytes = System.Text.Encoding.UTF8.GetBytes(body);
                request.ContentLength = postBytes.Length;
                Stream stream = request.GetRequestStream();
                stream.Write(postBytes, 0, postBytes.Length);
                stream.Close();

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }


        private string ReadResponse(HttpWebResponse response)
        {
            using (Stream responseStream = response.GetResponseStream())
            {
                Stream streamToRead = responseStream;
                if (streamToRead != null)
                    using (StreamReader streamReader = new StreamReader(streamToRead, Encoding.UTF8))
                    {
                        return streamReader.ReadToEnd();
                    }
            }
            return null;
        }
    }
}
