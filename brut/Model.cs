using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;

namespace brut
{
    public class ProxyItem 
    {
        public string proxy;
        public int countFail;
    }
    public class Model
    {

        List<string> sourceList = new List<string>();
        List<ProxyItem> proxyList = new List<ProxyItem>();

        public static string fileSource = @"..\..\dataSource.txt";
        public static string fileProxy = @"..\..\dataProxy.txt";

        public string[] allText;

        public string[] sourceData;
        public string[] proxyData;

        public List<ProxyItem> getProxyList()
        {
            return proxyList;
        }

        public List<string> getSourceList()
        {
            return this.sourceList;
        }

        public Model()
        {
            sourceData = getFileData(fileSource);
            proxyData = getFileData(fileProxy);
        }

        public string[] getFileData(string filePath)
        {
            if (File.Exists(filePath) != true)
            {
                return null;
            }

            allText = File.ReadAllLines(filePath);//чтение всех строк из файла в массив строк

            return allText;
        }

        public void addFileSource(CancellationToken cancellationToken)
        {
            foreach (string data in sourceData)
            {
                cancellationToken.ThrowIfCancellationRequested();

                try
                {
                    //записываем каждую строку файла в List<string>
                    if (!sourceList.Contains(data)) sourceList.Add(data);
                }
                catch { }

                cancellationToken.ThrowIfCancellationRequested();
            }
        }

        public void addFileProxy(CancellationToken cancellationToken)
        {
            foreach (string data in proxyData)
            {
                cancellationToken.ThrowIfCancellationRequested();

                try
                {
                    ProxyItem proxyItem = new ProxyItem();

                    proxyItem.proxy = data;
                    proxyItem.countFail=0;

                    //записываем каждую строку файла в List<string>
                    for(int i = 0; i < proxyList.Count; i++)
                    {
                        if (proxyList[i].proxy.Contains(proxyItem.proxy)) break;
                        else if(i!=proxyList.Count-1) continue; 
                        else { proxyList.Add(proxyItem); }
                    }

                    if (proxyList.Count == 0) proxyList.Add(proxyItem);
                }
                catch { }

                cancellationToken.ThrowIfCancellationRequested();

            }

        }

        public void addData(CancellationToken cancellationToken)
        {
            addFileSource(cancellationToken);
            addFileProxy(cancellationToken);
        }
    }
}
