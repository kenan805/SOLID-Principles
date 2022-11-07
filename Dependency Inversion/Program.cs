using Dependency_Inversion.DIPBad;
using Dependency_Inversion.DIPGood;

// Bad way
//var productService = new ProductService(new ProductRepositoryFromSqlServer());
//productService.GetAll().ForEach(x => { Console.WriteLine(x); });

//Good way
var productService = new ProductService2(new ProductRepositoryFromSqlServer2());
productService.GetAll().ForEach(x => { Console.WriteLine(x); });
// new repository
productService = new ProductService2(new ProductRepositoryFromOracle());
productService.GetAll().ForEach(x => { Console.WriteLine(x); });
