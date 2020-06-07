#ifdef MATH32_EXPORTS
#define MATH32_API __declspec(dllexport)
#else
#define MATH32_API __declspec(dllimport)
#endif



extern "C" MATH32_API int factorial(int n);


extern "C" MATH32_API double pow(double x, int n);

extern "C" MATH32_API double mabs(double x);


extern "C" MATH32_API double root(double num, int rootDegree);

