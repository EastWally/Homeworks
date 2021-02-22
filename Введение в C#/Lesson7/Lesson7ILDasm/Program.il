
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Lesson7
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 4C 65 73 73 6F 6E 37 00 00 )             // ...Lesson7..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 4C 65 73 73 6F 6E 37 00 00 )             // ...Lesson7..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 31 00 00 )                            //  2021..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 64 65 65 64 32 38 32 63 2D 31 31 63 36   // ..$deed282c-11c6
                                                                                                  2D 34 37 66 63 2D 39 35 63 37 2D 38 65 63 33 65   // -47fc-95c7-8ec3e
                                                                                                  32 64 34 65 32 63 35 00 00 )                      // 2d4e2c5..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Lesson7.exe
// MVID: {907A707E-8869-489E-AB02-839A35509B07}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x07130000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Lesson7.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       140 (0x8c)
    .maxstack  5
    .locals init ([0] int32 firstNumber,
             [1] bool isSecondNumber,
             [2] int32 secondNumber)
    IL_0000:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3F 04 35 04 40 04 32 04 3E 04 35 04 20 00 47 04   // ?.5.@.2.>.5. .G.
                                    38 04 41 04 3B 04 3E 04 3A 00 20 00 )             // 8.A.;.>.:. .
    IL_0005:  call       void [mscorlib]System.Console::Write(string)
    IL_000a:  call       string [mscorlib]System.Console::ReadLine()
    IL_000f:  ldloca.s   firstNumber
    IL_0011:  call       bool [mscorlib]System.Int32::TryParse(string,
                                                               int32&)
    IL_0016:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04   // ....2.5.4.8.B.5.
                                    20 00 32 04 42 04 3E 04 40 04 3E 04 35 04 20 00   //  .2.B.>.@.>.5. .
                                    47 04 38 04 41 04 3B 04 3E 04 3A 00 20 00 )       // G.8.A.;.>.:. .
    IL_001b:  call       void [mscorlib]System.Console::Write(string)
    IL_0020:  call       string [mscorlib]System.Console::ReadLine()
    IL_0025:  ldloca.s   secondNumber
    IL_0027:  call       bool [mscorlib]System.Int32::TryParse(string,
                                                               int32&)
    IL_002c:  stloc.1
    IL_002d:  ldloc.1
    IL_002e:  and
    IL_002f:  brfalse.s  IL_0058

    IL_0031:  ldstr      "{0} + {1} = {2}"
    IL_0036:  ldloc.0
    IL_0037:  box        [mscorlib]System.Int32
    IL_003c:  ldloc.2
    IL_003d:  box        [mscorlib]System.Int32
    IL_0042:  ldloc.0
    IL_0043:  ldloc.2
    IL_0044:  call       int32 Lesson7.Program::sum(int32,
                                                    int32)
    IL_0049:  box        [mscorlib]System.Int32
    IL_004e:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object,
                                                                object)
    IL_0053:  call       void [mscorlib]System.Console::WriteLine(string)
	
	IL_0058:  ldstr      "Substract function was added in il"
	IL_005d:  call       void [mscorlib]System.Console::WriteLine(string)
	
    IL_0062:  ldstr      "{0} + {1} = {2}"
    IL_0067:  ldloc.0
    IL_0068:  box        [mscorlib]System.Int32
    IL_006d:  ldloc.2
    IL_006e:  box        [mscorlib]System.Int32
    IL_0073:  ldloc.0
    IL_0074:  ldloc.2
    IL_0075:  call       int32 Lesson7.Program::subtract(int32,
                                                    int32)
    IL_007a:  box        [mscorlib]System.Int32
    IL_007b:  call       string [mscorlib]System.String::Format(string,
                                                                      object,
                                                                      object,
                                                                      object)
    IL_0080:  call       void [mscorlib]System.Console::WriteLine(string)
	
    IL_0085:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_008a:  pop
    IL_008b:  ret
  } // end of method Program::Main

  .method private hidebysig static int32 
          sum(int32 a,
              int32 b) cil managed
  {
    // Размер кода:       4 (0x4)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  add
    IL_0003:  ret
  } // end of method Program::sum
  
  .method private hidebysig static int32 
          subtract(int32 a,
              int32 b) cil managed
  {
    // Размер кода:       4 (0x4)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  sub
    IL_0003:  ret
  } // end of method Program::subtract

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class Lesson7.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 E:\Geekbrains\Homeworks\Lesson7\Lesson7ILDasm\Program.res
