using Bookstore.Application.DTOs.AuthorDTOs;
using Bookstore.Application.DTOs.BookDTOs;
using Bookstore.Application.DTOs.CustomerDTOs;
using Bookstore.Application.DTOs.GenreDTOs;
using Bookstore.Application.DTOs.OrderDetailsDTOs;
using Bookstore.Application.DTOs.OrderDTOs;
using Bookstore.Application.Services;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.Net;

namespace BookStore.ConsoleUI;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ShowMenu();
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1": ShowBooksMenu(); break;
                case "2": ShowAuthorsMenu(); break;
                case "3": ShowGenresMenu(); break;
                case "4": ShowCustomerOrderMenu(); break;
                case "0":
                    Console.WriteLine("Çıxılır...");
                    return;
                default:
                    Console.WriteLine("Yanlış seçim! Davam etmək üçün Enter basın.");
                    Console.ReadLine();
                    break;
            }
        }
    }
    static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║               BOOKSTORE MENU          ║");
        Console.WriteLine("╠═══════════════════════════════════════╣");
        

        Console.WriteLine("║  1.    Kitablar                       ║");
        Console.WriteLine("║    1.1 Yeni Kitab Əlavə Et            ║");
        Console.WriteLine("║    1.2 Kitab Siyahısı                 ║");
        Console.WriteLine("║    1.3 Kitab Axtar                    ║");
        Console.WriteLine("║    1.4 Kitabı Redaktə Et              ║");
        Console.WriteLine("║    1.5 Kitabı Sil                     ║");

        Console.WriteLine("║  2.   Müəlliflər                      ║");
        Console.WriteLine("║    2.1 Yeni Müəllif Əlavə Et          ║");
        Console.WriteLine("║    2.2 Müəllif Siyahısı               ║");
        Console.WriteLine("║    2.3 Müəllifin Kitabları            ║");

        Console.WriteLine("║  3.    Janrlar                        ║");
        Console.WriteLine("║    3.1 Yeni Janr Əlavə Et             ║");
        Console.WriteLine("║    3.2 Janr Siyahısı                  ║");

        Console.WriteLine("║  4.    Müştərilər və  Sifarişlər      ║  ");
        Console.WriteLine("║    4.1 Müştəri Qeydiyyatı             ║");
        Console.WriteLine("║    4.2 Yeni Sifariş                   ║");
        Console.WriteLine("║    4.3 Sifarişlərə Baxış              ║");

        Console.WriteLine("╠═══════════════════════════════════════╣");
        Console.WriteLine("║  0. Çıxış                             ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        Console.Write("Seçiminiz: ");
      
        }

    static void ShowBooksMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.    Kitablar                       ");
            Console.WriteLine("    1.1 Yeni Kitab Əlavə Et            ");
            Console.WriteLine("    1.2 Kitab Siyahısı                 ");
            Console.WriteLine("    1.3 Kitab Axtar                    ");
            Console.WriteLine("    1.4 Kitabı Redaktə Et              ");
            Console.WriteLine("    1.5 Kitabı Sil                     ");
            Console.WriteLine("0. Geri Dön");
            Console.Write("Seçiminiz: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1.1": BookMembers.AddBook(); break;
                case "1.2": BookMembers.GetAllBooks(); break;
                case "1.3": BookMembers.GetBook(); break;
                case "1.4": BookMembers.UpdateBook(); break;
                case "5": BookMembers.DeleteBook(); break;
                case "0": return;
                default:
                    Console.WriteLine("Yanlış seçim!");
                    break;
            }

            Console.WriteLine("\nDavam etmək üçün Enter basın...");
            Console.ReadLine();
        }
    }

    static void ShowAuthorsMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("2.   Müəlliflər                      ");
            Console.WriteLine("    2.1 Yeni Müəllif Əlavə Et          ");
            Console.WriteLine("    2.2 Müəllif Siyahısı               ");
            Console.WriteLine("    2.3 Müəllifin Kitabları            ");
            Console.WriteLine("0. Geri Dön");
            Console.Write("Seçiminiz: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "2.1": Authormembers.AddAuthor(); break;
                case "2.2": Authormembers.GetAllAuthor(); break;
                case "2.3": Authormembers.GetAllBooksofAuthor(); break;
                case "0": return;
                default:
                    Console.WriteLine("Yanlış seçim!");
                    break;
            }

            Console.WriteLine("\nDavam etmək üçün Enter basın...");
            Console.ReadLine();
        }
    }

    static void ShowGenresMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("3. Janrlar                        ");
            Console.WriteLine("    3.1 Yeni Janr Əlavə Et             ");
            Console.WriteLine("    3.2 Janr Siyahısı                  ");
            Console.WriteLine("0. Geri Dön");
            Console.Write("Seçiminiz: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "3.1": GenreMembers.AddGenre(); break;
                case "3.2": GenreMembers.GetAllGenre(); break;
                case "0": return;
                default:
                    Console.WriteLine("Yanlış seçim!");
                    break;
            }

            Console.WriteLine("\nDavam etmək üçün Enter basın...");
            Console.ReadLine();
        } }

    static void ShowCustomerOrderMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("4.Müştərilər və Sifarişlər      ");
                Console.WriteLine("    4.1 Müştəri Qeydiyyatı             ");
                Console.WriteLine("    4.2 Yeni Sifariş                   ");
                Console.WriteLine("    4.3 Sifarişlərə Baxış              ");
            Console.WriteLine("0. Geri Dön");
            Console.Write("Seçiminiz: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "4.1": CustomerMembers.AddCustomer(); break;
                    case "4.2": OrderMembers.AddOrder(); break;
                    case "4.3": OrderMembers.Orderdetails(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Yanlış seçim!");
                        break;
                }

                Console.WriteLine("\nDavam etmək üçün Enter basın...");
                Console.ReadLine();
            }
        }
 }
    
