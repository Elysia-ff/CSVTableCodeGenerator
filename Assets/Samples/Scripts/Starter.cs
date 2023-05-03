using Elysia.Tables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    private SampleDictionaryTable dictionaryTable;
    private SampleArrayTable arrayTable;

    private void Start()
    {
        dictionaryTable = new SampleDictionaryTable();
        dictionaryTable.Load();

        arrayTable = new SampleArrayTable();
        arrayTable.Load();

        // use values here
    }
}
