class MainController {
    constructor($http) {
        // this.message = "hello from main";
        $http.get("/api/now").then(res=>{
            this.message = res.data;
        });
        // this.message = this.now
    }
}