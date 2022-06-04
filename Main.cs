/*
NSCRIPT BY NULLFASTTERO
COPYRIGHT 2022
DON'T SKID
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Net;
using System.Threading;

namespace NullFasttero.Nscript
{
    public class Main
    {
        public static void Ejecutar(string comando)
        {
           Process.Start(comando);
        }
        public static void EjecutarComando(string comando)
        {
            Process.Start("cmd.exe", comando);
        }
        public static async void ProxyDescarga(string lugar, string tipo)
        {
          if(tipo == "HTTPS" || tipo ==  "https")
            {
                if(Directory.Exists(tipo))
                {
                    WebClient webClient = new WebClient();

                    await webClient.DownloadFileTaskAsync("https://raw.githubusercontent.com/TheSpeedX/PROXY-List/master/http.txt", lugar + "\\http.txt");
                } else
                {
                    MessageBox.Show("No declarastes bien el lugar que se descarge el archivo que quieres", "Nscript");
                }             
            }
          if (tipo == "SOCKS5" || tipo == "socks5")
            {
                if (Directory.Exists(tipo))
                {
                    WebClient webClient = new WebClient();

                    await webClient.DownloadFileTaskAsync("https://raw.githubusercontent.com/TheSpeedX/PROXY-List/master/socks5.txt", lugar + "\\socks5.txt");
                }
                else
                {
                    MessageBox.Show("No declarastes bien el lugar que se descarge el archivo que quieres", "Nscript");
                }
            }
          if (tipo == "socks4" || tipo == "socks4")
            {
                if (Directory.Exists(tipo))
                {
                    WebClient webClient = new WebClient();

                    await webClient.DownloadFileTaskAsync("https://raw.githubusercontent.com/TheSpeedX/PROXY-List/master/socks4.txt", lugar + "\\socks4.txt");
                }
                else
                {
                    MessageBox.Show("No declarastes bien el lugar que se descarge el archivo que quieres", "Nscript");
                }
            }
          else
            {
                MessageBox.Show("No declarastes bien el tipo de proxy que quieres", "Nscript");
            }
        }
        public static void Escribir(string texto)
        {
            Console.Write(texto);
        }
       public static void DiscordNitroGen()
        {
            Process.Start("https://rr.noordstar.me/5e704b3b");
        }
        public async static void Descargar(string link, string lugar, string nombre)
        {
            WebClient webClient = new WebClient();

            await webClient.DownloadFileTaskAsync(link, lugar + "\\" + nombre);
        }
        public async static void FakeHackercmd()
        {
            Process.Start("cmd.exe", "color a\ndir /s");
        }
        public async static void FakeHacked(string nombredelhacker)
        {
            Console.Write("Usted fue hackeado por: " + nombredelhacker + "sus archivos estan encriptados. Para desencriptados entre a este link para pagar 100$ si no lo hace tendremos que filtrar su informacion. Link: https://rr.noordstar.me/5e704b3b");
            Console.ReadLine();
        }
        public async static void CreditosMaker(string link)
        {
            Process.Start(link);
        }
    }
}
