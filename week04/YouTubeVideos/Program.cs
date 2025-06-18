using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        VideoManager videoManager = new VideoManager();

        
        videoManager.AddVideo("How to use canva");
        videoManager.AddVideo("Advanced Techniques and Transitions Slides");

        
        videoManager.AddComment("How to use canva", "Very helpful tutorial!");
        videoManager.AddComment("How to use canva", "Great explanation of basics.");
        videoManager.AddComment("How to use canva", "Loved the examples!");

        
        Console.WriteLine("Video Library:");
        videoManager.DisplayVideos();
    }
}



    
    

        
