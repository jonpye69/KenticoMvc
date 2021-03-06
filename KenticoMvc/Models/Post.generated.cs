//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.Mvc;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(Post.CLASS_NAME, typeof(Post))]

namespace CMS.DocumentEngine.Types.Mvc
{
	/// <summary>
	/// Represents a content item of type Post.
	/// </summary>
	public partial class Post : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "mvc.Post";


		/// <summary>
		/// The instance of the class that provides extended API for working with Post fields.
		/// </summary>
		private readonly PostFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// PostID.
		/// </summary>
		[DatabaseIDField]
		public int PostID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("PostID"), 0);
			}
			set
			{
				SetValue("PostID", value);
			}
		}


		/// <summary>
		/// Title.
		/// </summary>
		[DatabaseField]
		public string PostTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("PostTitle"), "");
			}
			set
			{
				SetValue("PostTitle", value);
			}
		}


		/// <summary>
		/// 
		/// </summary>
		[DatabaseField]
		public Guid PostImage
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("PostImage"), Guid.Empty);
			}
			set
			{
				SetValue("PostImage", value);
			}
		}


		/// <summary>
		/// Text.
		/// </summary>
		[DatabaseField]
		public string PostText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("PostText"), "");
			}
			set
			{
				SetValue("PostText", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Post fields.
		/// </summary>
		[RegisterProperty]
		public PostFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Post fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class PostFields : AbstractHierarchicalObject<PostFields>
		{
			/// <summary>
			/// The content item of type Post that is a target of the extended API.
			/// </summary>
			private readonly Post mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="PostFields" /> class with the specified content item of type Post.
			/// </summary>
			/// <param name="instance">The content item of type Post that is a target of the extended API.</param>
			public PostFields(Post instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// PostID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.PostID;
				}
				set
				{
					mInstance.PostID = value;
				}
			}


			/// <summary>
			/// Title.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.PostTitle;
				}
				set
				{
					mInstance.PostTitle = value;
				}
			}


			/// <summary>
			/// 
			/// </summary>
			public Attachment Image
			{
				get
				{
					return mInstance.GetFieldAttachment("PostImage");
				}
			}


			/// <summary>
			/// Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.PostText;
				}
				set
				{
					mInstance.PostText = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Post" /> class.
		/// </summary>
		public Post() : base(CLASS_NAME)
		{
			mFields = new PostFields(this);
		}

		#endregion
	}
}