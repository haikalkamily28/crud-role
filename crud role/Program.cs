using System;
using System.Collections.Generic;

class Role
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Role(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void DisplayRoleInfo()
    {
        Console.WriteLine($"ID Role: {Id}");
        Console.WriteLine($"Nama Role: {Name}");
    }
}

class Program
{
    static List<Role> roles = new List<Role>();

    static void Main(string[] args)
    {
        bool continueLoop = true;

        while (continueLoop)
        {
            Console.WriteLine("Pilih operasi:");
            Console.WriteLine("1. Tambah Role");
            Console.WriteLine("2. Tampilkan Role");
            Console.WriteLine("3. Update Role");
            Console.WriteLine("4. Hapus Role");
            Console.WriteLine("5. Keluar");
            Console.WriteLine("Pilihan Anda: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddRole();
                    break;
                case 2:
                    DisplayRoles();
                    break;
                case 3:
                    UpdateRole();
                    break;
                case 4:
                    DeleteRole();
                    break;
                case 5:
                    continueLoop = false;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }

    static void AddRole()
    {
        Console.WriteLine("Masukkan ID Role:");
        int roleId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Masukkan Nama Role:");
        string roleName = Console.ReadLine();

        Role newRole = new Role(roleId, roleName);
        roles.Add(newRole);
        Console.WriteLine("Role telah ditambahkan.");
    }

    static void DisplayRoles()
    {
        if (roles.Count == 0)
        {
            Console.WriteLine("Belum ada role yang ditambahkan.");
        }
        else
        {
            Console.WriteLine("\nDaftar Role:");
            foreach (var role in roles)
            {
                role.DisplayRoleInfo();
                Console.WriteLine();
            }
        }
    }

    static void UpdateRole()
    {
        Console.WriteLine("Masukkan ID Role yang akan diupdate:");
        int roleIdToUpdate = Convert.ToInt32(Console.ReadLine());

        Role roleToUpdate = roles.Find(r => r.Id == roleIdToUpdate);

        if (roleToUpdate != null)
        {
            Console.WriteLine("Masukkan Nama Role baru:");
            string newName = Console.ReadLine();

            roleToUpdate.Name = newName;
            Console.WriteLine("Role telah diupdate.");
        }
        else
        {
            Console.WriteLine("Role tidak ditemukan.");
        }
    }

    static void DeleteRole()
    {
        Console.WriteLine("Masukkan ID Role yang akan dihapus:");
        int roleIdToDelete = Convert.ToInt32(Console.ReadLine());

        Role roleToDelete = roles.Find(r => r.Id == roleIdToDelete);

        if (roleToDelete != null)
        {
            roles.Remove(roleToDelete);
            Console.WriteLine("Role telah dihapus.");
        }
        else
        {
            Console.WriteLine("Role tidak ditemukan.");
        }
    }
}