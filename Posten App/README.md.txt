Posten App

Status: Finished/Functional
- Changes can be made to support multiple Json files.
- Changes can be made to create a new text document when running the program, rather than overwriting the old results.
- Can maybe make the program more robust by editing privacy of a bunch of methods/fields.
- Can maybe make the program more robust by only allowing method CalculateOptimalPackageInfo() to be run 1 time per instance.
- Can make the different package options into objects, and change weight and dimensions based on those objects, to simplify the program.

How to use:
1. Place Json file you want calculated in "Posten App/Posten App/Jsonfiles".
2. It is important that the Json file is named "items" in lowercase, and placed in the correct folder.
3. Run Posten App.exe in "bin/debug/net8.0" with no arguments. The exe file MUST be run from that folder path. 
4. Results will be printed in the console and copied into "Posten App/Posten App/Results.txt".

Task interpretation:
- In spec 2: "Eske Norgespakke" will be chosen over all "Posten Box" types, if possible.

Authors: Sondre Pettersen & Heine Pettersen
--------------------------------------------------------------------------------------------------------

Misc notes:
As far as we know, the code is working as intended, but items such as Surf Magazine from the Json examples that are 
too big to be posted in "Brev under 350g", but too light to be posted with "Brev fra 350-2kg" have no posting option.
Don't know if this is intended or we missinterpreted the assignment specifications.