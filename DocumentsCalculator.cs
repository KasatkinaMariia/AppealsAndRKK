using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace AppealsAndRKK
{
    class ExecutorDocuments
    {
        public string Name { get; set; }
        public int RKKCount { get; set; }
        public int AppealsCount { get; set; }

        public int DocumentsTotal
        {
            get
            {
                return RKKCount + AppealsCount;
            }
        }
    }

    class DocumentsCalculator
    {
        private Dictionary<string, ExecutorDocuments> executorsDocumentsDictionary = new Dictionary<string, ExecutorDocuments>();
        public int RKKTotal { get; private set; }
        public int AppealsTotal { get; private set; }

        private List<string> DetermineResponsibleExecutors(string fileName)
        {
            Regex regex = new Regex(@"\w+ \w+\.\w+\.");
            var lines = File.ReadAllLines(fileName);
            List<string> result = new List<string>();
            foreach (var line in lines)
            {
                var names = line.Split('\t');
                if (names[0] == "Климов Сергей Александрович")
                    result.Add(regex.Match(names[1]).Value);
                else
                {
                    var executorName = names[0].Split(' ');
                    result.Add(executorName[0] + " " + executorName[1][0] + "." + executorName[2][0] + ".");
                }
            }
            return result;
        }

        public void Calculate(string RKKFileName, string AppealFileName)
        {
            var RKKResponsibleExecutors = DetermineResponsibleExecutors(RKKFileName);
            RKKTotal = RKKResponsibleExecutors.Count;
            executorsDocumentsDictionary = RKKResponsibleExecutors.GroupBy(x => x)
                                   .Select(x => new ExecutorDocuments()
                                   {
                                       Name = x.Key,
                                       RKKCount = x.Count(),
                                       AppealsCount = 0
                                   })
                                   .ToDictionary(x => x.Name, x => x);
            
            var AppealResponsibleExecutors = DetermineResponsibleExecutors(AppealFileName);
            AppealsTotal = AppealResponsibleExecutors.Count;
            var Appeal = AppealResponsibleExecutors.GroupBy(x => x)
                                                   .Select(x => Tuple.Create(x.Key, x.Count()));

            foreach (var el in Appeal)
            {
                if (!executorsDocumentsDictionary.ContainsKey(el.Item1))
                    executorsDocumentsDictionary.Add(el.Item1, 
                                                     new ExecutorDocuments()
                                                     {
                                                         Name = el.Item1,
                                                         RKKCount = 0,
                                                         AppealsCount = el.Item2
                                                     });
                else executorsDocumentsDictionary[el.Item1].AppealsCount = el.Item2;
            }
        }

        public List<List<object>> GetExecutorsDocumentsDictionary()
        {
            var result = new List<List<object>>();
            foreach (var el in executorsDocumentsDictionary)
            {
                result.Add(new List<object> {el.Key, 
                                             el.Value.RKKCount, 
                                             el.Value.AppealsCount, 
                                             el.Value.DocumentsTotal });
            }
            return result;
        }
    }
}
