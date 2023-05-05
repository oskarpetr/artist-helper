﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ColourHelperForm.Models;

namespace ColourHelperForm.Tools {
    public class Files {
        const string PAINTINGS = "Paintings/";
        const string DETAILS = "details.txt";

        public static List<string> GetPaintings() {
            List<string> images = new();

            string[] files = Directory.GetFiles(PAINTINGS);
            foreach (string file in files) {
                images.Add(file);
            }

            return images;
        }

        public static void CreatePainting(string path, int width, int height, Dictionary<string, double> colours) {
            File.Copy(path, $"Paintings/{Path.GetFileName(path)}");

            AddDetail(Path.GetFileNameWithoutExtension(path), width, height, colours);
        }

        public static void RemovePainting(string name) {
            File.Delete($"Paintings/{name}");

            RemoveDetail(name);
        }

        public static List<Detail> GetDetails() {
            using (var stream = File.Open(DETAILS, FileMode.OpenOrCreate)) {
                BinaryFormatter formatter = new();

                return (List<Detail>)formatter.Deserialize(stream);
            }
        }

        public static void AddDetail(string name, int width, int height, Dictionary<string, double> colours) {
            List<Detail> details = GetDetails();

            details.Add(new Detail() { Name = name, Width = width, Height = height, Colours = colours });

            using (var stream = File.Open(DETAILS, FileMode.Open)) {
                BinaryFormatter formatter = new();
                formatter.Serialize(stream, details);
            }
        }

        public static void RemoveDetail(string name) {
            List<Detail> details = GetDetails();

            Detail detail = details.FirstOrDefault(detail => detail.Name == name);
            details.Remove(detail);

            using (var stream = File.Open(DETAILS, FileMode.Open)) {
                BinaryFormatter formatter = new();
                formatter.Serialize(stream, details);
            }
        }

        public static Detail GetDetail(string name) {
            List<Detail> details = GetDetails();
            return details.FirstOrDefault(detail => detail.Name == name);
        }

        public static void Export(List<string> content, string path) {
            File.AppendAllLines(path, content);
        }

        public static string GetPath(string name) {
            List<string> images = GetPaintings();
            string path = images.FirstOrDefault(e => Path.GetFileNameWithoutExtension(e) == name);

            return path;
        }

        /*public static void Initialize() {
            using (var stream = File.Open(DETAILS, FileMode.OpenOrCreate)) {
                BinaryFormatter formatter = new();
                formatter.Serialize(stream, new List<Detail>() { });
            }
        }*/
    }
}