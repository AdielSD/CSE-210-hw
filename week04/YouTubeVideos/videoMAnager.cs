using System;
using System.Collections.Generic;

public class VideoManager
{
    private List<string> _videoList;
    private Dictionary<string, List<string>> _comments; 

    public VideoManager()
    {
        _videoList = new List<string>();
        _comments = new Dictionary<string, List<string>>();
    }

    public void AddVideo(string videoTitle)
    {
        _videoList.Add(videoTitle);
        _comments[videoTitle] = new List<string>();
    }

    public void AddComment(string videoTitle, string comment)
    {
        if (_comments.ContainsKey(videoTitle))
        {
            _comments[videoTitle].Add(comment);
        }
        else
        {
            Console.WriteLine($"Video '{videoTitle}' not found.");
        }
    }

    public void DisplayVideos()
    {
        foreach (var video in _videoList)
        {
            Console.WriteLine($"Video: {video}");
            if (_comments[video].Count > 0)
            {
                Console.WriteLine("Comments:");
                foreach (var comment in _comments[video])
                {
                    Console.WriteLine($"- {comment}");
                }
            }
            else
            {
                Console.WriteLine("No comments.");
            }
            Console.WriteLine();
        }
    }
}
