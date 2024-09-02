/*
 File Handling in c#

 Generally, the file is used to store the data. 

What is file handling?
----------------------
The term File Handling refers to the various operations like 
        1. creating the file, 
        2. reading from the file, 
        3. writing to the file,
        4. appending the file, etc

There are two basic operation which is mostly used in file handling is
        1. reading and 
       2.  writing of the file. 

The file becomes stream when we open the file for writing and reading

What is strem?
--------------
A stream is a sequence of bytes which is used for communication traveling from a source to destination 

Two stream can be formed from a file 
        1. Input stream which is used to read the file and
        2. Output stream is used to write in the file

In C#, System.IO namespace contains classes which handle 
        1. input stream and 
        2. output streams and 
        3. provide information about file and directory structure.


------------------------
INPUT -> READ OPERATION  - IR
OUTPUT -> WRITE OPERATION - OW
------------------------



                                      Object
                                        |
                                        |
            ---------------------------------------------------------------------
            |  System                           |           |       |           |
            |                                   |           |       |           |
      MarshalByRefObject                        |           |       |           |
            |                                   |           |       |           |    
            |  System.IO                        |           |       |           |
      FileSysteminfo                            |           |       |           |
            |                                   |           |       |           |
            |                                   |           |       |           |    
      --------------                            |           |       |           |
     |             |                            |           |       |           |
     |  System.io  |                            |           |       |           |   
 Fileinfo     Directoryinfo                    File        Path    Directory  Driveinfo





 

  When we want to work with files, we need to use the System.IO namespace;

  Here we have pre-defined classes, check below for some of the classes  


Classes		        Description
----------		    -----------------
FileStream          It is used to read from and write to any location within the file.

StreamWriter        It is used to write characters into a stream.
StreamReader        It is used to read characters from a byte stream.
                    For reading and writing characters by using an encoding value to convert the characters to and from bytes.

BinaryWriter        It is used to write data types in binary format.
BinaryReader        It is used to read data types from a binary stream.
                    For reading and writing primitive data types as binary values.

DirectoryInfo       It is used to perform operations on directories. (Folders)
FileInfo            It is used to perform operations on files.

---------------------

1. FileStream Class
syntax: The FileStream is a class used for reading and writing files in C#
-----------
FileStream <objectname>=new FileStream(<filename>,<FileModeEnumerator>,<FileAccessEnumerator>,<FileShareEnumerator>);	
FileStream fileObj = new FileStream(file Name/Path, FileMode.field, FileAccess.field, FileShare.field);


Parameters: 
FileName: Give the name of the file - Name of the file you want to work with along with its extension or
          the complete path of the file.
            
          Example:
          FileName.txt, 
          @”C:\Users\Username\Documents\FileName.txt”


FileModeEnumerator: It specifies which mode the file has to be opened in.
------------------
1. Append - opens if the file exists and places the cursor at the end of the file.

If the file does not exists then it will create a new file.

2. Create - Create a new file

3. Open - to open an existing file.

4. Truncate - To open a existing file and truncate its size to Zero byte

FileAccessEnumerator: It specifies the access to the file.
--------------------
These are the permissions 

1. Read - To read data from a file 

2. ReadWrite - To read and write data to a file

3. Write - To write data to a file

FileShareEnumerator: It specifies the access given to other FileStream objects to this particular file
-------------------
For whom we want to share permissions 

1. Read - To allow subsequent reading of the file.

2. ReadWrite - To allow subsequent reading and writing of the file

3. Write - To allow subsequent writing to the file.

4. None – To decline the sharing of the file

5. Delete - To allow subsequent deleting of the file

6. Inheritable – To allow the file handle inheritable by child processes.

---------------


2. StreamWriter
---------------
StreamWriter class in C# writes characters to a stream in a specified encoding.

StreamWriter.Write() method is responsible for writing text to a stream

StreamWriter class is inherited from the TextWriter class that provides methods
        to write an object to a string, 
        to write strings to a file, or 
        to serialize XML.

StreamWriter provides the following Write methods.

Method()        Description

Write()         Write data to the stream.
WriteAsync()    Writes data to the stream asynchronously.
WriteLine()     Writes a line terminator to the text string or stream.
WriteLineAsync  Writes a line terminator to the text string or stream asynchronously.
Close()         the current StreamWriter object and stream associate with it.
Flush()         Clears all the data from the buffer and write it in the stream associate with it.



3. StreamReader Class
-----------------------
The StreamReader class implements TextReader for reading character from the stream in a particular format

The class contains the following method which are mostly used.

Method()        Description

Close()	        Closes the current StreamReader object and stream associate with it.
Peek()	        Returns the next available character but does not consume it.
Read()	        Reads the next character in input stream and increment characters position by one in the stream
ReadLine()	    Reads a line from the input stream and return the data in form of string
Seek()	        It is use to read/write at the specific location from a file

 
 */
