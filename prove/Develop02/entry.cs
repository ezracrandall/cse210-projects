using System;
using System.Collections.Generic;

class Entry
{
    private string _prompt;
    private string _response;
    private string _date;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public string toString()
    {
        return $"Date: {_date}\n - Prompt: {_prompt}\n Response: {_response}\n";
    }
}