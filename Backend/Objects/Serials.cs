using System;
using System.Linq;

public class Serials 
{
    private string name;
    private string alias;
    private int[] episode_seasons;
    private bool[] did_watch;
    private string link;
    private DateTime latest_update;
    private int id;
    private SerialType type;

    public Serials(string name)
    {
        set_name(name);
    }

    public void set_name(string name)
    {
        this.name = name;
    }

    public string get_name()
    {
        return this.name;
    }

    public void set_alias(string alias)
    {
        this.alias = alias;
    }

    public string get_alias()
    {
        return this.alias;
    }

    public void set_episode_seasons(int[] episode_seasons)
    {
        this.episode_seasons = episode_seasons;
    }

    public int[] get_episode_seasons()
    {
        return episode_seasons;
    }

    public void set_link(string link)
    {
        this.link = link;
    }

    public string get_link()
    {
        return this.link;
    }

    public int get_Id()
    {
        return this.id;
    }

    public int set_Id()
    {
        return this.id;
    }

    public void add_watched_episode()
    {
        int index = get_index_latest_watched_episode();
        did_watch[index + 1] = true;
    }

    public void removed_watched_episode()
    {
        int index = get_index_latest_watched_episode();
        did_watch[index] = false;
    }

    private int get_index_latest_watched_episode()
    {
        return last_true(0, did_watch.Length - 1, did_watch);
    }

    private int last_true(int l, int r, bool[] array)
    {
        if (l > r)
        {
            return -1;
        }

        int m = l + (r - l) / 2;

        if (array[m])
        {
            int result = last_true(m + 1, r, array);
            return result == -1 ? m : result;
        }
        else
        {
            return last_true(l, m - 1, array);
        }
    }
}