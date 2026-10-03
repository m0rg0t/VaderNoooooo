using System;
using System.Reflection;
class Program {
 static int count;
 static void Check(bool value,string name) { if(!value) throw new Exception(name); count++; }
 static object Call(object target,string name,params object[] args) { return target.GetType().GetMethod(name,BindingFlags.Instance|BindingFlags.NonPublic).Invoke(target,args); }
 static void Main() { Test(); Console.WriteLine("PASS " + count + " source assertions"); }
 static void Test() { var p=new Noooooo.MainPage(); foreach(var name in new[]{"button1_Click","button2_Tap"}) {for(int i=0;i<2;i++) { Call(p,name,null,null); Check(p.no.Volume==1.0,"maximum volume must be 1.0");Check(p.no.Source.OriginalString=="/Nooo.mp3","original resource preserved"); Check(p.no.Position.Ticks==10000,"restart position preserved"); }}Check(p.no.Plays==4,"repeat playback requests"); } }