# UpdateConference2019
Course material for the AI for every developer course

[[_TOC_]]

------

# AI for every developer - [Update Conference Prague 2019](https://www.updateconference.net/) course material 
This is the repository with all the assets out of my speech at the Update Conference 2019 in Prague.
You can find the slides on the assts folder both in PDF and POwer Point format

# Requirements
To runn all the samples you're gonna need Visual Studio 2017 or 2019 (any version) to run all the .Net related samples.
You also gonna need .Net Core 3.0 installed on your machine.
To run the ONNX converter you need Docker installed on your system.

To run the notebooks and the Python/TensorFlow/Keras related samples you're gonna need Anaconda

# Cloning the repository
Open a Bash prompt, move on the parent directory where you want to clone the repository and type the following command on a Bash console:

```
git clone https://github.com/gsantopaolo/UpdateConference2019.git
```

# Installing and configuring Anaconda
## Download and Install Anaconda Python 3.7

https://www.anaconda.com/download/

## Open an Anaconda prompt and change to course folder

```
cd UpdateConference2019
```

## Create the course environment
if you want to use the CPU
```
conda env create
```
If you have an NVidia GPU GTX/RTX
```
conda env create -f environment-gpu.yml
```

wait for the environment to create.

## Activate the environment
```
conda activate ai_for_every_dev
```

Check that your prompt changed to

```
(ai_for_every_dev) $
```

## Launch Jupyter Notebook

```
jupyter notebook
```

## Run the Check environment Notebook

Go to the notebooks folder, open the notebook `check_environment.ipynb` and run it. If you see the message:

    Houston we are go!

You are good to go! Enjoy!


## Troubleshooting installation
If for some reason you don't see `Houston we are go!`, the simplest solution is to delete the environment and start from scratch again.

To remove the environment:

- close the browser and go back to your terminal
- stop jupyter notebook (CTRL-C)
- deactivate the environment:

```
conda deactivate
```

- delete the environment:

```
conda env remove -n ai_for_every_dev
```

- restart from environment creation and make sure that each steps completes till the end.

## Updating Conda

One thing you can also try is to update your conda executable. This may help if you already had Anaconda installed on your system.

```
conda update conda
```
# Samples
