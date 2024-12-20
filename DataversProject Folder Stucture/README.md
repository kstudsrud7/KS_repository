Source: `https://benediktbergmann.eu/2021/04/27/folder-structure-of-a-dataverse-project/`
How to Deplay
- Run following Power Shell Commands
- cd "C:\Users\kstudsrud\source\repos\DataversProject Folder Stucture" ## Root Folder
- mkdir -p Development\Azure
- mkdir -p Development\Back-end\Applications
- mkdir -p Development\Back-end\Plugins
- mkdir -p Development\Back-end\Shared
- mkdir -p Development\Back-end\Workflows
- mkdir -p Development\Front-end\PCF
- mkdir -p Development\Front-end\ts\src\code\utils
- mkdir -p Development\Front-end\ts\src\code\tables
- mkdir -p Development\Front-end\ts\src\code\ribbon
- mkdir -p Development\Front-end\ts\test
- mkdir -p Development\Front-end\Webresources\html
- mkdir -p Development\Front-end\Webresources\css
- mkdir -p Development\Front-end\Webresources\images
- mkdir -p Development\Front-end\Webresources\js
- mkdir -p PowerPlatform\CanvasApps
- mkdir -p PowerPlatform\Config\Schema
- mkdir -p PowerPlatform\Config\Data
- mkdir -p PowerPlatform\Solutions
- mkdir -p PowerPlatform\(Tools)
- mkdir spkl
- mkdir Pipelines



# Root
The root contains 3 folders.

## 1 Development
It is the folder where all the development is happening. All sourceCode (except of unpacked Canvas Apps) are stored here.

## 2 PowerPlatform
This folder contains everything which is related to the PowerPlatform and isn’t code a developer implements.

## 3 Pipelines
This folder usually contains the yaml definition of the project’s pipelines. Since I normally work with Azure DevOps it’s called Pipelines.
If you use GitHub the naming is misleading since the same approach (Pipelines) is called “workflows” in GitHub.
This folder does not need any further explanation.

# 2 PowerPlatform
As mentioned this folder contains everything which isn’t code.

## CanvasApps
In this folder, I store the unpacked sourceCode of the CanvasApps. Read here how to unpack a CanvasApp in your pipeline.

## Config
Since every environment should be replaceable (as Scott Durow (LinkedIn& Twitter) describes here) the configuration data should be stored in your repository. Another reason is to be able to hold all the different environments in sync when it comes to configuration data.
Therefore I tend to have one folder called “Schema” containing the export schema of the projects configuration data. As well as another folder containing the exported data.
I either use the Configuration Migration Utility or the Data Transporter of the XrmToolBox if it is a manual process.

## Solutions
This folder contains all the solutions the project has. Every Solution will have a subfolder that contains the unpacked solution content.

## Tools
Not every time I have this folder. When it’s there it contains tools needed for some parts of the platform. Mostly for automation. For example, the PaSopa to unpack CanvasApps or a small CMD Application to install an additional language to an environment.

What could be discussed is where the definition of custom connectors should be stored. Either in this folder or under development.

# 1 Development
Now we came to the interesting part of the folder structure of a Dataverse project. The Development folder is split into three areas Azure, Back-end and Front-end.

## Azure
This depends on what parts of the Azure stack the project is utilizing. It could for example contain ARM-Templates for Azure Functions. A good approach could be to have subfolders structuring the different components even further.

It could be discussed to create a separate repository for all the Azure stuff since it’s not directly related to anything in Dataverse.
## Back-end
The Backend folder consists of the following subfolders.

## Applications
This folder contains Applications “around” dataverse. For example APIs, BatchJobs or custom Portals.

## Plugins
As the name says this folder contains all the plugins. There are different approaches to plugins. One could either have one bit assembly containing all plugins (which I don’t recommend), split the assemblies by tables or split the assemblies by area. To only mentioned some of the possibilities. I like to split the assemblies by tables.

## Shared
The Shared folder contains all the VS projects which contain shared code. This could be a plugin base class or a shared logic class which could be used by Plugins, Workflows and other Applications to ensure a consistent logic across all parts of the implementation. Most of the projects in this folder are “Shared Projects“.
An example could be your Early Bound project which could/should be shared between Plugins, Workflow steps and custom applications (like APIs).

## Workflows
Here again the name says it all. In this folder I store my custom workflow steps. Those get less and less.

It might be useful to separate stuff like custom Actions, custom APIs (here I talk about the approach in Dataverse) or custom data provider for virtual tables.
# Front-end
The Front-end folder contains everything which is client side code.

## PCF
As the name suggests this folder contains all the custom PCF components of the project. Every component should have its own sub folder.

## spkl
I use Sparkle XRM from Scott Durow (LinkedIn& Twitter) to deploy my Webresources. This folder contains all the needed configuration as well as the Spkl files.

As you can read in this blog post I moved the spkl folder to the root of “Development” to be able to deploy Plugins also.
## ts
This folder contains all necessary files to develop TypeScript. The TypeScript will then be transpiled into JavaScript and stored in the Webresources folder from where it will be deployed via spkl.

In this article, you can read in detail how I set up my TypeScript projects.
# Webresources
Here all the needed Webresources are stored. I usually have a folder for css, html and images. Those could have sub folders depending on the amount of files. Notice that I don’t have a js folder in my repo since those files get generated when I transpile my TypeScript files.