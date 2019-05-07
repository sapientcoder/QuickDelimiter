# QuickDelimiter

This is a simple tool I threw together that takes column-based data and converts it to delimited text on a single line. You can use it
to make comma-delimited text, pipe-delimited text, or whatever else you need.

The main thing I use it for is copying a list of values out of database query results and then inserting those into WHERE clauses
elsewhere.

![screen shot of tool](https://yieldreturnpost.files.wordpress.com/2019/05/quickdelimiter.jpg)

**How to Use**

Start by copying your source data into the big text box labeled "Source data."

If you don't want extra spaces/junk in the final output, leave the box checked for "Trim source data rows." That trims leading and trailing whitespace
off each line. (Note: Blank lines are always ommitted from the output even if this box is unchecked.)

Put your delimiter (comma, pipe, etc.) in the "Delimiter" field, and hit _Convert_ to generate the final delimited string. Then you can click
"Copy to Clipboard" to copy it straight to your clipboard for pasting.

You can also optionally enter a prefix and suffix.

For example, let's say you want the output to be something like: (value1),(value2),(value3). You'd enter a prefix of "(", enter "),(" as the delimiter, and enter ")"
as the suffix to get that output.
