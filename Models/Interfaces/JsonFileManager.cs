﻿using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using KursachFileSaving.Models.Classes;
using System.Xml;

namespace KursachFileSaving.Models.Interfaces
{
    public static class JsonFileManager
    {
        private static string FilePath = "data.json";

        public static void SaveData(List<Apps> apps, List<Blocks> blocks, List<Employees> employees, List<Jobs> jobs, List<Journal> journal, List<PO> po, List<WorkType> workTypesModel)
        {
            var data = new
            {
                Apps = apps,
                Blocks = blocks,
                Employees = employees,
                Jobs = jobs,
                Journal = journal,
                PO = po,
                WorkTypesModel = workTypesModel
            };

            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static (List<Apps>, List<Blocks>, List<Employees>, List<Jobs>, List<Journal>, List<PO>, List<WorkType>) LoadData()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                var data = JsonConvert.DeserializeObject<dynamic>(json);

                var apps = data.Apps.ToObject<List<Apps>>();
                var blocks = data.Blocks.ToObject<List<Blocks>>();
                var employees = data.Employees.ToObject<List<Employees>>();
                var jobs = data.Jobs.ToObject<List<Jobs>>();
                var journal = data.Journal.ToObject<List<Journal>>();
                var po = data.PO.ToObject<List<PO>>();
                var workTypesModel = data.WorkTypesModel.ToObject<List<WorkType>>();

                return (apps, blocks, employees, jobs, journal, po, workTypesModel);
            }
            else
            {
                return (new List<Apps>(), new List<Blocks>(), new List<Employees>(), new List<Jobs>(), new List<Journal>(), new List<PO>(), new List<WorkType>());
            }
        }
        public static List<Jobs> LoadJobs()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<Jobs>>(json);
            }
            else
            {
                return new List<Jobs>();
            }
        }
        public static List<Blocks> LoadBlocks()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                var data = JsonConvert.DeserializeObject<dynamic>(json);
                return data.Blocks.ToObject<List<Blocks>>();
            }
            else
            {
                return new List<Blocks> { };
            }
        }
        public static List<Apps> LoadApps()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                var data = JsonConvert.DeserializeObject<dynamic>(json);
                return data.Apps.ToObject<List<Apps>>();
            }
            else
            {
                return new List<Apps> { };
            }
        }
        public static List<WorkType> LoadWTs()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<WorkType>>(json);
            }
            else
            {
                return new List<WorkType>();
            }
        }
        public static List<Employees> LoadEmps()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                var data = JsonConvert.DeserializeObject<dynamic>(json);
                return data.Employees.ToObject<List<Employees>>();
            }
            else
            {
                return new List<Employees> { };
            }
        }
        public static List<PO> LoadPOs()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                var data = JsonConvert.DeserializeObject<dynamic>(json);
                return data.PO.ToObject<List<PO>>();
            }
            else
            {
                return new List<PO> { };
            }
        }
        public static List<Journal> LoadJournal()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                var data = JsonConvert.DeserializeObject<dynamic>(json);
                return data.Journal.ToObject<List<Journal>>();
            }
            else
            {
                return new List<Journal> { };
            }
        }
        public static void SaveJobs(List<Jobs> jobslist, string filePath)
        {
            var (apps, blocks, employees, jobs, journal, po, workTypesModel) = LoadData();
            jobs = jobslist;
            SaveData(apps,blocks,employees,jobs,journal,po,workTypesModel);
        }
        public static void SaveWTs(List<WorkType> wtslist, string filePath)
        {
            var (apps, blocks, employees, jobs, journal, po, workTypesModel) = LoadData();
            workTypesModel = wtslist;
            SaveData(apps, blocks, employees, jobs, journal, po, workTypesModel);
        }
        public static void SavePOs(List<PO> polist, string filePath)
        {
            var (apps, blocks, employees, jobs, journal, po, workTypesModel) = LoadData();
            po = polist;
            SaveData(apps, blocks, employees, jobs, journal, po, workTypesModel);
        }
        public static void SaveBlocks(List<Blocks> blockslist, string filePath)
        {
            var (apps, blocks, employees, jobs, journal, po, workTypesModel) = LoadData();
            blocks = blockslist;
            SaveData(apps, blocks, employees, jobs, journal, po, workTypesModel);
        }
        public static void SaveEmps(List<Employees> empslist, string filePath)
        {
            var (apps, blocks, employees, jobs, journal, po, workTypesModel) = LoadData();
            employees = empslist;
            SaveData(apps, blocks, employees, jobs, journal, po, workTypesModel);
        }
        public static void SaveApps(List<Apps> appslist, string filePath)
        {
            var (apps, blocks, employees, jobs, journal, po, workTypesModel) = LoadData();
            apps = appslist;
            SaveData(apps, blocks, employees, jobs, journal, po, workTypesModel);
        }
        public static void SaveJournal(List<Journal> journalList, string filePath)
        {
            var (apps, blocks, employees, jobs, journal, po, workTypesModel) = LoadData();
            journal = journalList;
            SaveData(apps, blocks, employees, jobs, journal, po, workTypesModel);
        }

        public static void InitializeDataIfFileNotExists()
        {
            // Инициализация всех списков данных
            var emptyAppsList = new List<Apps>();
            var emptyBlocksList = new List<Blocks>();
            var emptyEmployeesList = new List<Employees>();
            var emptyJobsList = new List<Jobs>();
            var emptyJournalList = new List<Journal>();
            var emptyPoList = new List<PO>();
            var emptyWorkTypesModel = new List<WorkType>();

            // Сохранение пустых данных в JSON-файл
            JsonFileManager.SaveData(emptyAppsList, emptyBlocksList, emptyEmployeesList, emptyJobsList, emptyJournalList, emptyPoList, emptyWorkTypesModel);
        }
    }
}