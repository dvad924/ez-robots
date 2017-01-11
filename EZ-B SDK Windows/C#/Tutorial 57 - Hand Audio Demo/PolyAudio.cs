using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Tutorial_57___Hand_Audio_Demo {

  public class PolyAudio {

    public class SoundFile {

      public SoundFile(string filename) {

        Audio = System.IO.File.ReadAllBytes(filename);
      }

      public byte [] Audio;
    }

    public class Player {

      WaveFileReader audio; 
      IWavePlayer    player;
      
      public void Play(SoundFile soundFile) {

        Stop();

        audio = new WaveFileReader(new System.IO.MemoryStream(soundFile.Audio));
        player = new WaveOut(WaveCallbackInfo.FunctionCallback());

        if (player.PlaybackState == PlaybackState.Playing)
          player.Stop();

        player.Init(audio);

        player.Play();
      }

      public void Stop() {

        if (player != null) {

          player.Stop();
          player.Dispose();
        }

        if (audio != null) {

          audio.Close();
          audio.Dispose();
        }
      }

      public void Dispose() {

        Stop();
      }
    }

    List<Player>      _players            = new List<Player>();
    int               _currentPlayerIndex = 0;

    public PolyAudio(int polyCount) {

      for (int x = 0; x < polyCount; x++)
        _players.Add(new Player());
    }

    public void Dispose() {

      foreach (Player player in _players)
        player.Dispose();
    }

    public void Play(SoundFile soundFile) {

      _players[_currentPlayerIndex].Play(soundFile);

      _currentPlayerIndex++;

      if (_currentPlayerIndex >= _players.Count)
        _currentPlayerIndex = 0;
    }
  }
}
