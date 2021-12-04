using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
  public class GameManager
  {
    private readonly int _gravity = 2;
    public int previousScore = 0;
    public int score = 0;
    public event EventHandler MainLoopCompleted;
    public BirdModel Bird { get; private set; }
    public List<PipeModel> Pipes { get; private set; }
    public List<ScoreModel> Scores { get; private set; }
    public bool IsRunning { get; private set; } = false;
    public GameManager() {
      Bird = new BirdModel();
      Pipes = new List<PipeModel>();
      Scores = new List<ScoreModel>();
    }

    public async void MainLoop() {
      IsRunning = true;
      while (IsRunning) {
        MoveObjects();
        CheckForCollisions();
        ManagePipes();

        MainLoopCompleted?.Invoke(this, EventArgs.Empty);
        await Task.Delay(20);
      }
    }

    public void StartGame() {
      if (!IsRunning) {
        Bird = new BirdModel();
        Pipes = new List<PipeModel>();
        Scores = new List<ScoreModel>();
        Scores.Add(new ScoreModel(0));
        MainLoop();
      }
    }

    public void Jump() {
      if (IsRunning) {
        Bird.Jump();
      }
    }

    void ManagePipes() {
      // if (Pipes.Last().DistanceFromLeft <= 200) {
      //   manageScore();
      // }

      if (!Pipes.Any() || Pipes.Last().DistanceFromLeft <= 250) {
        Pipes.Add(new PipeModel());
      }

      // if (Pipes.First().IsOffScreen()) {
      //   Pipes.Remove(Pipes.First());
      // }

      if (Pipes.First().DistanceFromLeft <= 160) {
        manageScore();
      }
      
    }

    public void MoveObjects() {
      Bird.Fall(_gravity);
        foreach(var pipe in Pipes) {
          pipe.Move();
        }
    }

    public void CheckForCollisions() {
      if (Bird.IsOnGround()) {
          GameOver();
      }
      var centeredPipe = Pipes.FirstOrDefault(p => p.IsCentered());
      if (centeredPipe != null) {
        bool hasCollidedWithBottom = Bird.DistanceFromGround < centeredPipe.GapBottom - 150;
        bool hasCollidedWithTop = Bird.DistanceFromGround + 45 > centeredPipe.GapTop - 150;
        if (hasCollidedWithBottom || hasCollidedWithTop) {
          GameOver();
        } 
      }
    }

    public void GameOver() {
      IsRunning = false;
    }

    private void manageScore()
    {
      var newScore = 0;
    
      foreach(var pipe in Pipes) {
        newScore += 1;
      }
      
      var temp = newScore;

      if (newScore != score) {
        while (Scores.Any()) {
          Scores.Remove(Scores.First());
        }

        var tempStr = "";
        while (temp > 0) {
          tempStr += (temp%10).ToString();
          temp /= 10;
        }
        for (int i = tempStr.Length - 1; i > -1; i--) {
          Scores.Add(new ScoreModel(tempStr[i]-'0'-1)); 
        }

        score = newScore;
      }
    }
  }

}