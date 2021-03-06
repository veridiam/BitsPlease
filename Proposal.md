# BitsPlease Video Suite

> Video editing for a new generation of content

by Annie Ho, George Krutous, Alex Mason, Erik Pomarede, Bianca Pricop

---

## Concept

The goal is to create a new system for editing video content on desktop computers that is faster and easier to use than existing video production software. By breaking up tasks into separate applications, simple tasks such as cutting, ordering, cropping, adding effects, and modifying audio become more streamlined. We will know our goal is met if a user is able to perform a simple video editing task faster than an existing tool (Sony Vegas, Adobe Premiere) without any instruction.

Our users are both non-technical as well as proficient. We hope that by paring down the number of options given to the user for a particular task, the software will become more easily learnable without instruction. These users' needs are video editing tools that allow them to quickly edit existing compressed video files without the time investment of large scale production sofware or hardware requirements of lengthy rendering and encoding processes.

The endeavor to create a brand new type of intuitive interface for a well established category of software is a challenge going forward for this project. Users experienced with existing software will have certain expectations and mental models of such a system, and inexperienced users will possibly desire to leap to more heavy duty production software after learning the basics of video editing with our software. We will need to work within some constraints to ensure these issues are addressed. For instance, using a standard timeline interface for sequencing video. Another potential challenge is getting users accustomed to using multiple applications in combination to perform complex operations. For example, to keep the video sequencer simple, it will not feature functionality to cut video clips, only sequence them. Our software will need to teach users to combine the video clipper with the video sequencer.

## Development Approach

The bulk of our video operations will be performed by the open source library FFMPEG, which has a command line interface. Operations will be queued up by the UI and performed when the user saves their output. To display video preview, we will need to use another library such as libmpv. An example of libmpv in use with C# language and WinForms can be found [here](https://github.com/mpv-player/mpv-examples/tree/master/libmpv/csharp). C# WinForms and WPF applications are quick to develop and have a native-look, which will be important for our usability as we intend for existing operating system applications such as the file explorer to be an integral part of our interoperability.

We intend to use the agile software engineering method to develop each individual application. Since functionality may be moved from one application to another, or to an entirely new application, an interative approach is required. For example, the decision to separate video cutting and sequencing into two seperate applications came out of the usability design of the sequencer interface.

For IAT 351, we intent to implement the following components:

* Sequencer
* Clipper
* Cropper
* Converter
* Colour Correct
* YouTube Downloader

For user testing, we intend to perform usability studies.

## Design Approach

Our approach will be iterative, undertaking a series of steps:

1) Outline subgoals which achieve the main end goal (ie. outputting an edited video).
2) Outline the functionality required to complete the subgoals.
3) Propose tasks that achieve that functionality.
4) Sketch/storyboard the workflow.
5) Implement tasks in code and interface.
6) User test new features for efficiency and UX.
7) Revise and reiterate steps 3-6.

## Preliminary Analysis

We are considering Nielsen's heuristic evaluations to analyze usability in our interface. Nielsen's heuristics cover a broad range of concepts, such as "error prevention rather than error messages," and "information should appear in a natural and logical order." We can use them to assess our overall interface, as well as more granular interactions within it. Heuristic evaluations are a flexible way to plan and reflect on our design process.

As designers, we run the danger of being biased by our familiarity to the project. We believe that heuristic evaluations will allow us to think about the interface more objectively. Comparing the UI against sets of criteria may reveal issues that otherwise wouldn't occur to us. To verify the strength of our implementation, we can incorporate heuristics as goals to be tested in user studies.