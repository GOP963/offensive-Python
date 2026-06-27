from setuptools import setup
from Cython.Build import cythonize

setup(
    ext_modules=cythonize("sh_loader.pyx")
)