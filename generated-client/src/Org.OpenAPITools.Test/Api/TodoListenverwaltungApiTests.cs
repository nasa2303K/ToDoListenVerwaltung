/*
 * Todo-Listenverwaltung API
 *
 * API zur Verwaltung von Todo-Listen und deren Einträgen
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: asad.saleem@gmx.de
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing TodoListenverwaltungApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TodoListenverwaltungApiTests : IDisposable
    {
        private TodoListenverwaltungApi instance;

        public TodoListenverwaltungApiTests()
        {
            instance = new TodoListenverwaltungApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TodoListenverwaltungApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TodoListenverwaltungApi
            //Assert.IsType<TodoListenverwaltungApi>(instance);
        }

        /// <summary>
        /// Test CreateEntry
        /// </summary>
        [Fact]
        public void CreateEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid listId = null;
            //NewEntry newEntry = null;
            //var response = instance.CreateEntry(listId, newEntry);
            //Assert.IsType<Entries>(response);
        }

        /// <summary>
        /// Test CreateTodoList
        /// </summary>
        [Fact]
        public void CreateTodoListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewTodoList newTodoList = null;
            //var response = instance.CreateTodoList(newTodoList);
            //Assert.IsType<TodoList>(response);
        }

        /// <summary>
        /// Test DeleteEntry
        /// </summary>
        [Fact]
        public void DeleteEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid listId = null;
            //Guid entryId = null;
            //var response = instance.DeleteEntry(listId, entryId);
            //Assert.IsType<DeleteTodoList200Response>(response);
        }

        /// <summary>
        /// Test DeleteTodoList
        /// </summary>
        [Fact]
        public void DeleteTodoListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid listId = null;
            //var response = instance.DeleteTodoList(listId);
            //Assert.IsType<DeleteTodoList200Response>(response);
        }

        /// <summary>
        /// Test GetTodoList
        /// </summary>
        [Fact]
        public void GetTodoListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid listId = null;
            //var response = instance.GetTodoList(listId);
            //Assert.IsType<TodoList>(response);
        }

        /// <summary>
        /// Test GetallEntries
        /// </summary>
        [Fact]
        public void GetallEntriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid listId = null;
            //var response = instance.GetallEntries(listId);
            //Assert.IsType<List<Entries>>(response);
        }

        /// <summary>
        /// Test GetallTodoList
        /// </summary>
        [Fact]
        public void GetallTodoListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetallTodoList();
            //Assert.IsType<List<TodoList>>(response);
        }

        /// <summary>
        /// Test UpdateEntry
        /// </summary>
        [Fact]
        public void UpdateEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid listId = null;
            //Guid entryId = null;
            //NewEntry newEntry = null;
            //var response = instance.UpdateEntry(listId, entryId, newEntry);
            //Assert.IsType<UpdateEntry200Response>(response);
        }
    }
}
