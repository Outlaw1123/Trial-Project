// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections;


namespace UEDS
{
	public interface IGlobalEditorSettingsIOProvider
	{
		/// <summary>
		/// Returns true if the writer has finished the writing process. 
		/// </summary>
		/// <value><c>true</c> if writer finished; otherwise, <c>false</c>.</value>
		bool WriterFinished	{ get; }

		/// <summary>
		/// Returns true if there was an error during the writer process. The writer process should finish automatically if this happens. 
		/// </summary>
		/// <value><c>true</c> if writer has error; otherwise, <c>false</c>.</value>
		bool WriterHasError	{ get; }

		/// <summary>
		/// The error occured during the write process. 
		/// </summary>
		/// <value>The writer error.</value>
		string WriterError	{ get; }

		/// <summary>
		/// Starts the process of writing the given SerializedRoot Instance. 
		/// </summary>
		/// <param name="pObject">P object.</param>
		/// <param name="pPath">P path.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		void Save<T>(T pObject, string pPath) where T : SerializedRoot, new();

		/// <summary>
		/// Returns true if the loader has finished the loading process. 
		/// </summary>
		/// <value><c>true</c> if loader finished; otherwise, <c>false</c>.</value>
		bool LoaderFinished	{ get; }
		/// <summary>
		/// Returns true if there was an error during the loader process. The loader process should finish automatically if this happens. 
		/// </summary>
		/// <value><c>true</c> if loader has error; otherwise, <c>false</c>.</value>
		bool LoaderHasError	{ get; }
		/// <summary>
		/// The error that occured during the loading process. null or empty string if no error occured. 
		/// </summary>
		/// <value>The loader error.</value>
		string LoaderError	{ get; }
		/// <summary>
		/// Loads a SerializedRoot Object from the given path in xml. 
		/// </summary>
		/// <param name="pPath">P path.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		void Load<T>(string pPath) where T : SerializedRoot, new();

		/// <summary>
		/// Checks if the given path (in pParams) exists and sets the result (in pParams)
		/// </summary>
		/// <param name="pParams">P parameters.</param>
		IEnumerator Exists(ExistCheckParams pParams);

		/// <summary>
		/// Creates an empty instance of SerializeRoot. 
		/// </summary>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		void CreateEmpty<T>() where T : SerializedRoot, new();

		/// <summary>
		/// Returns the currently loaded data. 
		/// </summary>
		/// <returns>The data.</returns>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		T GetData<T>() where T : SerializedRoot, new();

	}
}

