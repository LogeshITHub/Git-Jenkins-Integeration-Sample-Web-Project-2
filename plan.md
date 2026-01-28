# Mutual Fund Website - Development Plan

## Project Overview
**Technology Stack:**
- ASP.NET Core Web App (MVC)
- Visual Studio Code
- Roo Code Tool (OpenRouter integration)
- Modern CSS (No frameworks - custom responsive design)
- Mock Data (No database required initially)

**Goal:** Create a modern, realistic mutual fund website with clean UI/UX

---

## Phase 1: Project Setup & Foundation (Day 1)

### 1.1 Project Initialization
- [ ] Create ASP.NET Core Web App (MVC) project
- [ ] Set up folder structure:
  ```
  /wwwroot
    /css
    /js
    /images
    /assets
  /Models
  /Controllers
  /Views
  /Data (for mock data)
  ```

### 1.2 Core Models Creation
Create the following model classes in `/Models`:

**Fund.cs**
```csharp
- FundId (int)
- FundName (string)
- FundType (enum: Equity, Debt, Hybrid, Index)
- Category (string)
- CurrentNAV (decimal)
- DayChange (decimal)
- DayChangePercent (decimal)
- MinInvestment (decimal)
- ExpenseRatio (decimal)
- RiskLevel (enum: Low, Medium, High, VeryHigh)
- Returns1Year (decimal)
- Returns3Year (decimal)
- Returns5Year (decimal)
- Rating (int, 1-5 stars)
- AMCName (string - Asset Management Company)
- LaunchDate (DateTime)
- Description (string)
```

**Portfolio.cs**
```csharp
- PortfolioId (int)
- UserId (int)
- FundId (int)
- UnitsHeld (decimal)
- InvestedAmount (decimal)
- CurrentValue (decimal)
- PurchaseDate (DateTime)
- XIRR (decimal)
```

**Transaction.cs**
```csharp
- TransactionId (int)
- UserId (int)
- FundId (int)
- TransactionType (enum: Buy, Sell, SIP)
- Amount (decimal)
- Units (decimal)
- NAV (decimal)
- TransactionDate (DateTime)
- Status (enum: Pending, Completed, Failed)
```

**User.cs**
```csharp
- UserId (int)
- FullName (string)
- Email (string)
- PhoneNumber (string)
- PanNumber (string)
- KYCStatus (enum: Pending, Verified)
- TotalInvested (decimal)
- CurrentValue (decimal)
- TotalReturns (decimal)
```

### 1.3 Mock Data Service
Create `/Data/MockDataService.cs`:
- Generate 20-30 realistic mutual funds
- Create sample user portfolio
- Generate transaction history
- Include various fund categories and performance data

### 1.4 Base CSS Framework
Create `/wwwroot/css/main.css`:
- CSS Variables for theming (colors, spacing, fonts)
- Reset and base styles
- Responsive grid system
- Utility classes

---

## Phase 2: Home Page & Navigation (Day 2)

### 2.1 Layout Structure
Create `/Views/Shared/_Layout.cshtml`:
- Modern navigation header with logo
- Sticky navigation on scroll
- Main content area
- Footer with links and info
- Responsive mobile menu (hamburger)

### 2.2 Home Page Components
Create `/Views/Home/Index.cshtml`:

**Components to build:**
1. **Hero Section**
   - Eye-catching headline
   - Investment calculator teaser
   - CTA buttons (Start Investing, Explore Funds)
   - Background with subtle gradient/pattern

2. **Market Overview Cards**
   - Top performing funds (3-4 cards)
   - Display NAV, returns, rating
   - Hover effects with modern transitions

3. **Why Invest Section**
   - 3-4 feature cards
   - Icons (using CSS shapes or Unicode)
   - Benefits: Diversification, Professional Management, Liquidity, Tax Benefits

4. **Fund Categories Section**
   - Grid of fund types (Equity, Debt, Hybrid, Index)
   - Visual representation with colors
   - Quick stats for each category

5. **How It Works Section**
   - Step-by-step process (3-4 steps)
   - Timeline or numbered flow
   - Clean, minimal design

### 2.3 CSS Styling
Create `/wwwroot/css/home.css`:
- Hero section with gradient backgrounds
- Card designs with shadows and hover states
- Responsive grid layouts
- Smooth transitions and animations
- Mobile-first responsive design

**Key Design Elements:**
- Color Scheme: Professional blues/greens with white/gray
- Typography: Clean sans-serif, hierarchical headings
- Spacing: Consistent padding/margins using 8px grid
- Shadows: Subtle box-shadows for depth
- Border-radius: Modern rounded corners (4-8px)

---

## Phase 3: Fund Listing & Details (Day 3)

### 3.1 Fund Explorer Page
Create `/Views/Funds/Index.cshtml`:

**Features:**
1. **Filter Sidebar**
   - Fund Type checkboxes
   - Risk Level filter
   - Minimum Investment slider
   - Sort options (Returns, Rating, NAV)

2. **Fund Cards Grid**
   - Responsive grid (3 columns desktop, 1 mobile)
   - Each card shows:
     - Fund name and AMC
     - Current NAV with change indicator
     - 1Y/3Y/5Y returns
     - Star rating
     - Quick invest button
   - Pagination or load more

3. **Search Functionality**
   - Search bar at top
   - Real-time filter (JavaScript)

### 3.2 Fund Details Page
Create `/Views/Funds/Details.cshtml`:

**Sections:**
1. **Fund Header**
   - Fund name, category, AMC
   - Current NAV (large, prominent)
   - Day change with color coding
   - Star rating

2. **Quick Stats Grid**
   - 6-8 key metrics in cards
   - Min Investment, Expense Ratio, Risk Level
   - AUM, Launch Date, Exit Load

3. **Performance Chart Placeholder**
   - Tabs for 1Y/3Y/5Y/All time
   - Placeholder for chart (can add Chart.js later)
   - Returns comparison table

4. **Fund Information Tabs**
   - About Fund
   - Investment Strategy
   - Risk Factors
   - Top Holdings (mock data)

5. **Investment Action Panel**
   - Sticky sidebar or bottom panel
   - Amount input
   - One-time vs SIP toggle
   - Invest Now button

### 3.3 CSS Styling
Create `/wwwroot/css/funds.css`:
- Filter sidebar with smooth transitions
- Card hover effects with scale/shadow
- Color-coded performance indicators (green/red)
- Star rating display (CSS stars)
- Responsive tabs design
- Clean form inputs with focus states

---

## Phase 4: Portfolio Dashboard (Day 4)

### 4.1 Dashboard Layout
Create `/Views/Portfolio/Index.cshtml`:

**Components:**

1. **Summary Cards Row**
   - Total Invested (₹)
   - Current Value (₹)
   - Total Returns (₹ and %)
   - Today's Change
   - Each card with icon and color coding

2. **Portfolio Holdings Table**
   - Sortable columns
   - Fund Name, Units, Invested, Current, Returns, %Change
   - Row hover effects
   - Action buttons (Buy more, Redeem)

3. **Asset Allocation Chart**
   - Placeholder for pie/donut chart
   - Breakdown by fund type
   - CSS-based simple visualization or use Chart.js

4. **Recent Transactions**
   - Timeline-style layout
   - Last 10 transactions
   - Transaction type, amount, date, status
   - Status badges (Completed, Pending)

5. **Quick Actions Panel**
   - New Investment
   - Start SIP
   - Redeem Funds
   - Download Statement

### 4.2 CSS Styling
Create `/wwwroot/css/portfolio.css`:
- Dashboard card designs with gradients
- Table with alternating rows, hover states
- Status badges with colors
- Responsive dashboard grid
- Mobile-optimized table (cards on mobile)

---

## Phase 5: Investment Flow (Day 5)

### 5.1 Investment Form
Create `/Views/Investment/Create.cshtml`:

**Form Components:**
1. **Fund Selection** (if not coming from fund details)
   - Dropdown or search
   - Display selected fund info

2. **Investment Type**
   - Radio buttons: One-time / SIP
   - Conditional fields based on selection

3. **Amount Input**
   - Number input with validation
   - Min/Max checks
   - Calculate units preview (Amount / NAV)

4. **SIP Options** (if SIP selected)
   - Frequency dropdown (Monthly, Quarterly)
   - Start date picker
   - End date or number of installments

5. **Payment Method**
   - Radio buttons (Net Banking, UPI, Debit Card)
   - Mock payment integration

6. **Confirmation Screen**
   - Summary of investment
   - Terms & conditions checkbox
   - Confirm button

### 5.2 Success/Confirmation Page
Create `/Views/Investment/Success.cshtml`:
- Success animation (CSS)
- Transaction summary
- Transaction ID
- Download receipt button
- Next steps (Go to Portfolio, Invest More)

### 5.3 CSS Styling
Create `/wwwroot/css/investment.css`:
- Multi-step form indicator
- Clean form styling with labels
- Radio/Checkbox custom styling
- Validation error states
- Success animation (checkmark)

---

## Phase 6: Additional Pages & Polish (Day 6)

### 6.1 SIP Calculator
Create `/Views/Tools/SIPCalculator.cshtml`:

**Features:**
- Monthly investment input
- Expected return rate slider
- Time period slider
- Real-time calculation display
- Visual representation of growth
- Results: Total invested, Expected returns, Maturity amount

### 6.2 Lumpsum Calculator
Create `/Views/Tools/LumpsumCalculator.cshtml`:
- Similar to SIP but one-time investment
- Investment amount input
- Expected return and tenure sliders
- Growth visualization

### 6.3 About Page
Create `/Views/Home/About.cshtml`:
- Company information
- Mission and vision
- Why choose us
- Team section (optional with mock data)

### 6.4 Contact Page
Create `/Views/Home/Contact.cshtml`:
- Contact form (Name, Email, Phone, Message)
- Office address
- Support email/phone
- Social media links

### 6.5 CSS Styling
Create `/wwwroot/css/tools.css` and `/wwwroot/css/pages.css`:
- Calculator UI with sliders
- Results display with animations
- Form styling consistency
- Responsive layouts

---

## Phase 7: Responsive Design & Final Touches (Day 7)

### 7.1 Mobile Optimization
- [ ] Test all pages on mobile viewport
- [ ] Implement hamburger menu
- [ ] Optimize tables for mobile (card view)
- [ ] Touch-friendly buttons and inputs
- [ ] Mobile-specific CSS adjustments

### 7.2 Cross-browser Testing
- [ ] Chrome
- [ ] Firefox
- [ ] Safari
- [ ] Edge

### 7.3 Performance Optimization
- [ ] Minimize CSS
- [ ] Optimize images
- [ ] Lazy loading where applicable
- [ ] Check page load times

### 7.4 Accessibility
- [ ] Semantic HTML
- [ ] ARIA labels where needed
- [ ] Keyboard navigation
- [ ] Color contrast checks
- [ ] Alt text for images

### 7.5 Final Polish
- [ ] Consistent spacing across pages
- [ ] Uniform color scheme
- [ ] Smooth transitions
- [ ] Loading states for actions
- [ ] Error handling and validation messages
- [ ] 404 page design

---

## CSS Architecture

### Color Palette
```css
:root {
  --primary: #2563eb;        /* Blue */
  --primary-dark: #1e40af;
  --secondary: #10b981;      /* Green */
  --accent: #f59e0b;         /* Amber */
  --danger: #ef4444;         /* Red */
  --text-dark: #1f2937;
  --text-light: #6b7280;
  --bg-light: #f9fafb;
  --bg-white: #ffffff;
  --border: #e5e7eb;
  --shadow: rgba(0, 0, 0, 0.1);
}
```

### Breakpoints
```css
/* Mobile: 320px - 767px */
/* Tablet: 768px - 1023px */
/* Desktop: 1024px+ */
/* Large Desktop: 1440px+ */
```

### Typography Scale
```css
--font-xs: 0.75rem;    /* 12px */
--font-sm: 0.875rem;   /* 14px */
--font-base: 1rem;     /* 16px */
--font-lg: 1.125rem;   /* 18px */
--font-xl: 1.25rem;    /* 20px */
--font-2xl: 1.5rem;    /* 24px */
--font-3xl: 1.875rem;  /* 30px */
--font-4xl: 2.25rem;   /* 36px */
```

---

## Controller Structure

### HomeController
- Index() - Home page
- About() - About page
- Contact() - Contact page
- ContactSubmit() [POST] - Handle contact form

### FundsController
- Index() - Fund listing with filters
- Details(int id) - Fund details page
- Search(string query) - Search funds

### PortfolioController
- Index() - Portfolio dashboard
- Holdings() - Detailed holdings view
- Transactions() - Transaction history

### InvestmentController
- Create(int fundId) - Investment form
- Process() [POST] - Handle investment
- Success(int transactionId) - Confirmation page

### ToolsController
- SIPCalculator() - SIP calculator page
- LumpsumCalculator() - Lumpsum calculator page

---

## Mock Data Guidelines

### Fund Data Realism
- NAV range: ₹10 - ₹500
- Day change: -3% to +3%
- 1Y returns: -5% to +25%
- 3Y returns: 5% to +18%
- 5Y returns: 8% to +15%
- Expense ratio: 0.5% to 2.5%
- Min investment: ₹500, ₹1000, ₹5000

### Portfolio Mock Data
- 5-8 funds in portfolio
- Mix of equity, debt, hybrid
- Varied purchase dates
- Some profitable, some at loss
- Realistic transaction history

---

## JavaScript Requirements (Minimal)

### Essential JS Files
1. **main.js** - Navigation, mobile menu, scroll effects
2. **filters.js** - Fund filtering and search
3. **calculator.js** - SIP/Lumpsum calculations
4. **investment.js** - Form validation, unit calculation

Keep JavaScript minimal and vanilla (no jQuery needed).

---

## Testing Checklist

### Functionality
- [ ] All navigation links work
- [ ] Filters apply correctly
- [ ] Forms validate properly
- [ ] Calculations are accurate
- [ ] Data displays correctly

### UI/UX
- [ ] Consistent design across pages
- [ ] Smooth animations
- [ ] Responsive on all devices
- [ ] Good color contrast
- [ ] Clear call-to-actions

### Performance
- [ ] Fast page loads
- [ ] No console errors
- [ ] Images optimized
- [ ] CSS minified for production

---

## Future Enhancements (Post-MVP)

- Database integration (Entity Framework Core)
- User authentication (ASP.NET Identity)
- Real-time NAV updates
- Chart.js for performance graphs
- Email notifications
- Document upload (KYC)
- Advanced filtering with AJAX
- Export portfolio to PDF/Excel
- Market news integration
- Goal-based investing tools

---

## Development Tips for Roo Code Tool

1. **Work in phases** - Complete one phase before moving to next
2. **Test frequently** - Run the app after each major component
3. **Use mock data liberally** - Don't worry about database initially
4. **CSS-first approach** - Build visual design before adding functionality
5. **Mobile-first CSS** - Start with mobile styles, then enhance for desktop
6. **Comment your code** - Especially CSS for complex layouts
7. **Use semantic HTML** - Proper tags for better structure
8. **Version control** - Commit after each phase completion

---

## Time Estimates

- Phase 1: 3-4 hours
- Phase 2: 4-5 hours
- Phase 3: 5-6 hours
- Phase 4: 4-5 hours
- Phase 5: 3-4 hours
- Phase 6: 4-5 hours
- Phase 7: 3-4 hours

**Total: 26-33 hours of development**

---

## Success Criteria

✅ Modern, professional UI that looks production-ready
✅ Fully responsive (mobile, tablet, desktop)
✅ All core pages functional with mock data
✅ Smooth user experience with transitions
✅ Clean, maintainable code
✅ No external CSS frameworks (pure CSS mastery)
✅ Ready for database integration in next phase

---

**Good luck with your mutual fund website! Start with Phase 1 and build incrementally. Each phase builds on the previous one, so maintain code quality throughout.**
