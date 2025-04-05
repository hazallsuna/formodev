// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

/*
XmlLog xmlLog = new XmlLog();
DbLog dbLog = new DbLog();
JsonLog jsonLog = new JsonLog();
LogManager logManager = new LogManager(xmlLog, dbLog, jsonLog);
logManager.LogKaydet(LogType.json, "403 nolu durum oluştu"); */

var loggers = new Dictionary<LogType, ILog>
{
    { LogType.xml, new XmlLog() },
    { LogType.db, new DbLog() },
    { LogType.json, new JsonLog() }
};

var logManager = new LogManager(loggers);
logManager.LogKaydet(LogType.json, "403 nolu durum oluştu");
