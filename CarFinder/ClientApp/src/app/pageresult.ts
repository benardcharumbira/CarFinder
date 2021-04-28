export class PageResult {
    constructor(
        public count: number,
        public pageIndex: number,
        public pageSize: number,
        public items: any[]
     ) {}
   }