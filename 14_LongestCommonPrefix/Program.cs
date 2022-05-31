using System.Net;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic;
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var strs = new string[]{"flow", "flex", "flower"};

var result = LongestCommonPrefix(strs);
System.Console.WriteLine(result);


static string LongestCommonPrefix(string[] strs) {
    if(strs.Length == 0) return "";
    var prefix = strs[0];
    System.Console.WriteLine($"prefix is: {prefix}");

    for(int i = 0; i<strs.Length; i++){
        while(strs[i].IndexOf(prefix) != 0){
            prefix = prefix.SubString(0, prefix.Length() - 1);
            System.Console.WriteLine($"prefix is: {prefix}");
            
        }
    }


    return "b";
}