export interface Asset {
    assetId: number;
    symbol: string;
    name: string;
    type: string;
    sector?: string;
    exchange?: string;
    currency: string;
    portfolioAssets?: any;  
    assetPrices?: any;      
    transactions?: any;     
    news?: any;             
    comments?: any;         
    forecasts?: any;        
  }
  