﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCKViewer.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PCKViewer.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon APP {
            get {
                object obj = ResourceManager.GetObject("APP", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 图形图像浏览器支持以下几种类型图像文件的浏览：
        ///	1)Windows位图(*.bmp)
        ///	2)TGA图像(*.tga)
        ///	3)Photoshop文档(*.psd)
        ///1、浏览文件
        ///文件载入后，状态栏会显示文件类型、图像尺寸、文件大小等信息，图像窗口显示整张图像，通过滑动鼠标滚轮可放大、缩小图像，也可通过点击菜单项“视图”——“放大”和“缩小”两个菜单项来进行，当图像无法完整的显示在图像窗口时，拖动图像窗口的横向或纵向滚动条可平移图像。
        ///2、另存文件
        ///打开菜单项“文件”——“另存为”可直接保存文件，默认保存格式为该文件在PCK包内的原始格式，也可以另存为JPG、PBG、GIF三种格式格式。
        ///3、调整背景颜色
        ///如果所浏览的图像含有透明像素，则图片框的背景颜色会显示出来，此时打开菜单项“视图”——“背景颜色”，即可选择切换自己需要的颜色。 的本地化字符串。
        /// </summary>
        internal static string help_ImageView {
            get {
                return ResourceManager.GetString("help_ImageView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 本工具用于演示PCK格式的游戏资源文件的解压缩功能，支持部分格式为PCK国产老游戏的资源文件，同时还引入了第三方类库FreeImage和NAudio，实现图像和声音浏览功能。
        ///
        ///目前支持的游戏有：
        ///1、《大秦悍将》
        ///另外基于与上述相同或相近版本的游戏引擎的游戏也可解压，请自行尝试。
        ///
        ///【基本操作】
        ///1、打开PCK文件：
        ///点击“打开”按钮，按照操作提示打开PCK文件，选定文件后，开始解析包文件内部文件结构，稍等2-3秒即可显示处理结果。本工具支持拖拽方式打开文件，将PCK文件拖入资源包文件列表即可打开。如果显示“支持的格式，可以解压！(共有xxx个文件)”则表示读取成功，如果显示“未知的支持的格式，不可以解压！”则表示读取失败。
        ///2、浏览包内文件：
        ///本工具目前支持以下几种类型的文件浏览：
        ///　1)文本类
        ///　 ①TXT文本文件(*.txt)
        ///　 ②特效配置文件(*.gfx)
        ///　 ③模型配置文件(*.mod)
        ///　 ④着色器文件(*.sdr)
        ///　 ⑤资源配置文件(*.res)
        ///　2)图形图像类
        ///　 ①Windows位图(*.bmp) 
        ///　 ②TGA图像(*.tga) 
        ///　 ③Ph [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string help_Main {
            get {
                return ResourceManager.GetString("help_Main", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 图形图像浏览器支持以下几种类型图像文件的浏览：
        ///	1)WAV音频(*.wav)
        ///	2)MP3音频(*.mp3)
        ///1、试听声音
        ///声音文件载入后，状态栏会显示声音文件类型、音频时长、文件大小等信息，点击播放、暂停按钮可控制声音播放、暂停欲停止，在播放状态下拖动进度滑块可跳转播放。
        ///2、另存文件
        ///打开菜单项“文件”——“另存为”可直接保存文件，目前对于声音文件仅支持保存为该文件在PCK包内的原始格式。 的本地化字符串。
        /// </summary>
        internal static string help_SoundView {
            get {
                return ResourceManager.GetString("help_SoundView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 文本浏览器支持以下几种类型文本文件的浏览：
        ///	1)TXT文本文件(*.txt) 
        ///	2)特效配置文件(*.gfx)
        ///	3)模型配置文件(*.mod)
        ///	4)着色器文件(*.sdr)
        ///	5)资源配置文件(*.res)
        ///1、浏览文件
        ///文件载入后，状态栏会显示文件类型、文本行数、文件大小等信息，文本框显示的文本就是文本内容。
        ///2、另存文件
        ///打开菜单项“文件”——“另存为”可直接保存文件，默认保存格式为该文件在PCK包内的原始格式，也可以另存为TXT格式。
        ///2、调整字体大小
        ///打开菜单项“视图”——“字体大小”，根据自己的阅读习惯来选择小、常规、大和特大四种大小的字体。
        ///3、启用禁用护眼模式
        ///为避免视觉疲劳，浏览器默认开启护眼模式，护眼模式的文本框背景颜色为市面上常用的橄榄绿颜色，可有效缓解眼疲劳，如需关闭，点击菜单项“视图”——“护眼模式”，此时文本框背景颜色就会恢复为常规颜色。 的本地化字符串。
        /// </summary>
        internal static string help_TextView {
            get {
                return ResourceManager.GetString("help_TextView", resourceCulture);
            }
        }
    }
}