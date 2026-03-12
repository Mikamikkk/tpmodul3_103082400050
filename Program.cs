using System;
using System.Collections.Generic;

namespace tpmodul3_103082400050
{
    // Bagian 3: Implementasi Table-Driven untuk Kode Pos
    class KodePos
    {
        private static Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
        {
            {"Batununggal", "40266"}, {"Kujangsari", "40287"}, {"Mengger", "40267"},
            {"Wates", "40256"}, {"Cijaura", "40287"}, {"Jatisari", "40286"},
            {"Margasari", "40286"}, {"Sekejati", "40286"}, {"Kebonwaru", "40272"},
            {"Maleer", "40274"}, {"Samoja", "40273"}
        };

        public static string getKodePos(string kelurahan)
        {
            if (tabelKodePos.ContainsKey(kelurahan))
            {
                return tabelKodePos[kelurahan];
            }
            return "Data tidak ditemukan";
        }
    }

    // Bagian 5: Implementasi State-Based Construction untuk Pintu
    class DoorMachine
    {
        public enum State { Terkunci, Terbuka }
        public State currentState;

        public DoorMachine()
        {
            // Asumsi state awal adalah terkunci sesuai instruksi
            currentState = State.Terkunci;
        }

        public void Transisi(string command)
        {
            if (currentState == State.Terkunci && command == "BukaPintu")
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else if (currentState == State.Terbuka && command == "KunciPintu")
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Simulasi Table-Driven (Instruksi No. 3)
            Console.WriteLine("--- Output Table-Driven (Kode Pos) ---");
            string kel = "Batununggal";
            string kodepos = KodePos.getKodePos(kel);
            Console.WriteLine($"Kelurahan: {kel}, Kode Pos: {kodepos}");
            Console.WriteLine();

            // 2. Simulasi State-Based (Instruksi No. 5)
            Console.WriteLine("--- Output State-Based (Pintu) ---");
            DoorMachine pintu = new DoorMachine();
            
            // Menampilkan status awal sesuai instruksi No. 5.C
            if (pintu.currentState == DoorMachine.State.Terkunci) 
            {
                Console.WriteLine("Pintu terkunci");
            }

            // Simulasi perubahan state (Instruksi No. 5.E)
            pintu.Transisi("BukaPintu");
            pintu.Transisi("KunciPintu");
        }
    }
}