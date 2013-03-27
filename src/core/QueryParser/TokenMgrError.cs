/* 
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/* Generated By:JavaCC: Do not edit this line. TokenMgrError.java Version 4.1 */
/* JavaCCOptions: */

using System;
using System.Runtime.Serialization;

namespace Lucene.Net.QueryParsers
{
	
	/// <summary>Token Manager Error. </summary>
	[Serializable]
	public class TokenMgrError:System.ApplicationException
	{
		/// <summary> You can also modify the body of this method to customize your error messages.
		/// For example, cases like LOOP_DETECTED and INVALID_LEXICAL_STATE are not
		/// of end-users concern, so you can return something like :
		/// 
		/// "Internal Error : Please file a bug report .... "
		/// 
		/// from this method for such cases in the release version of your parser.
		/// </summary>
		public override System.String Message
		{
			get
			{
				return base.Message;
			}
			
		}
		
		/*
		* Ordinals for various reasons why an Error of this type can be thrown.
		*/
		
		/// <summary> Lexical error occurred.</summary>
		internal const int LEXICAL_ERROR = 0;
		
		/// <summary> An attempt was made to create a second instance of a static token manager.</summary>
		internal const int STATIC_LEXER_ERROR = 1;
		
		/// <summary> Tried to change to an invalid lexical state.</summary>
		internal const int INVALID_LEXICAL_STATE = 2;
		
		/// <summary> Detected (and bailed out of) an infinite loop in the token manager.</summary>
		internal const int LOOP_DETECTED = 3;
		
		/// <summary> Indicates the reason why the exception is thrown. It will have
		/// one of the above 4 values.
		/// </summary>
		internal int errorCode;
		
		/// <summary> Replaces unprintable characters by their escaped (or unicode escaped)
		/// equivalents in the given string
		/// </summary>
		protected internal static System.String addEscapes(System.String str)
		{
			System.Text.StringBuilder retval = new System.Text.StringBuilder();
			char ch;
			for (int i = 0; i < str.Length; i++)
			{
				switch (str[i])
				{
					
					case (char) (0): 
						continue;
					
					case '\b': 
						retval.Append("\\b");
						continue;
					
					case '\t': 
						retval.Append("\\t");
						continue;
					
					case '\n': 
						retval.Append("\\n");
						continue;
					
					case '\f': 
						retval.Append("\\f");
						continue;
					
					case '\r': 
						retval.Append("\\r");
						continue;
					
					case '\"': 
						retval.Append("\\\"");
						continue;
					
					case '\'': 
						retval.Append("\\\'");
						continue;
					
					case '\\': 
						retval.Append("\\\\");
						continue;
					
					default: 
						if ((ch = str[i]) < 0x20 || ch > 0x7e)
						{
							System.String s = "0000" + System.Convert.ToString(ch, 16);
							retval.Append("\\u" + s.Substring(s.Length - 4, (s.Length) - (s.Length - 4)));
						}
						else
						{
							retval.Append(ch);
						}
						continue;
					
				}
			}
			return retval.ToString();
		}
		
		/// <summary> Returns a detailed message for the Error when it is thrown by the
		/// token manager to indicate a lexical error.
		/// Parameters :
		/// EOFSeen     : indicates if EOF caused the lexical error
		/// curLexState : lexical state in which this error occurred
		/// errorLine   : line number when the error occurred
		/// errorColumn : column number when the error occurred
		/// errorAfter  : prefix that was seen before this error occurred
		/// curchar     : the offending character
		/// Note: You can customize the lexical error message by modifying this method.
		/// </summary>
		protected internal static System.String LexicalError(bool EOFSeen, int lexState, int errorLine, int errorColumn, System.String errorAfter, char curChar)
		{
			return ("Lexical error at line " + errorLine + ", column " + errorColumn + ".  Encountered: " + (EOFSeen?"<EOF> ":("\"" + addEscapes(System.Convert.ToString(curChar)) + "\"") + " (" + (int) curChar + "), ") + "after : \"" + addEscapes(errorAfter) + "\"");
		}
		
		/*
		* Constructors of various flavors follow.
		*/
		
		/// <summary>No arg constructor. </summary>
		public TokenMgrError()
		{
		}
		
		/// <summary>Constructor with message and reason. </summary>
		public TokenMgrError(System.String message, int reason):base(message)
		{
			errorCode = reason;
		}
		
		/// <summary>Full Constructor. </summary>
		public TokenMgrError(bool EOFSeen, int lexState, int errorLine, int errorColumn, System.String errorAfter, char curChar, int reason):this(LexicalError(EOFSeen, lexState, errorLine, errorColumn, errorAfter, curChar), reason)
		{
		}

	    public TokenMgrError(SerializationInfo info, StreamingContext context)
	            : base(info, context)
	    {
	    }
	}
    /* JavaCC - OriginalChecksum=1c94e13236c7e0121e49427992341ee3 (do not edit this line) */
}