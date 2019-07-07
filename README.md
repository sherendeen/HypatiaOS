# HypatiaOS
HYPATIA OS is an OS based on the CosmosOS project. 

# Command Registrar
Keeps track of registered commands. Some commands may be unregistered, and operate outside this framework.

# Commands and behavior
A command is represented by a class. A command may have one or more behaviors. Behaviors are all executed one after anouther. 

A behavior is based on the behavior superclass where it may override Execute(). The rationale behind behavior is that different registered commands may reuse previously defined behaviors for different ends. 

# Kernel Instance Accessibility
Outside the context of the kernel class, certain methods are unusuable as they are defined in Sys.Kernel. However, some commands may need to use the instanced kernel, and so the Command Registrar has been updated to cover this. To help distinguish between Sys.Kernel and Kernel (our additions), we will use the term Mind to describe our own extensions to the kernel.

# SimpleDialogueBehavior
Enables easy dialogues with prompts, listed options, and selectable options. This kind of treads on the ground of ListBehavior so there may be need to either further distinguish these or to merge them.
