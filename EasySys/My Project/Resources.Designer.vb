﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("EasySys.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  使用此强类型资源类，为所有资源查找
        '''  重写当前线程的 CurrentUICulture 属性。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找类似 最后编辑时间：2023-8-26
        '''
        '''1.写入或删除注册表时如果已打开注册表编辑器无法在注册表编辑器看到写入的值。（重启注册表编辑器可以看到）
        '''2.通过提取资源的注册表文件不支持ANSI,UTF-8，注册表编辑器导入中文会乱码(要求是UTF-8或ANSI，ANSI,UTF-8导出资源无法导入 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property bugs() As String
            Get
                Return ResourceManager.GetString("bugs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 Windows Registry Editor Version 5.00
        '''
        '''[HKEY_CLASSES_ROOT\DesktopBackground\Shell\OldPersonalize]
        '''@=hex(2):00,00
        '''&quot;HideInSafeMode&quot;=&quot;&quot;
        '''&quot;Icon&quot;=hex(2):25,00,73,00,79,00,73,00,74,00,65,00,6d,00,72,00,6f,00,6f,00,74,\
        '''  00,25,00,5c,00,73,00,79,00,73,00,74,00,65,00,6d,00,33,00,32,00,5c,00,74,00,\
        '''  68,00,65,00,6d,00,65,00,63,00,70,00,6c,00,2e,00,64,00,6c,00,6c,00,2c,00,2d,\
        '''  00,31,00,00,00
        '''&quot;Position&quot;=&quot;Bottom&quot;
        '''&quot;SubCommands&quot;=&quot;&quot;
        '''&quot;MUIVerb&quot;=&quot;个性化 (控制面板)&quot;
        '''
        '''[HKEY_CLASSES_ROOT\DesktopBackground\Shell\OldPerson [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property OldPersonalizeAdd() As String
            Get
                Return ResourceManager.GetString("OldPersonalizeAdd", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
