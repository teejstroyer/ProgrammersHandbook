// See https://aka.ms/new-console-template for more information
using ProgrammersHandbook.SortingAlgorithms;

var s = new SortingAlgorithms();
s.Run(algorithm: SortingAlgorithm.All, length: 10000, duplicates: false, reverse: false, print: false, time: true, verify: false);
s.Run(algorithm: SortingAlgorithm.All, length: 10000, duplicates: true, reverse: false, print: false, time: true, verify: false);
s.Run(algorithm: SortingAlgorithm.All, length: 10000, duplicates: false, reverse: true, print: false, time: true, verify: false);
s.Run(algorithm: SortingAlgorithm.All, length: 10000, duplicates: true, reverse: true, print: false, time: true, verify: false);

